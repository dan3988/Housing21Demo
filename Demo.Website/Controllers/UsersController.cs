﻿using System.Globalization;
using System.Net;

using CsvHelper;
using CsvHelper.Configuration;

using Demo.Website.Data;
using Demo.Website.Entities;
using Demo.Website.Exceptions;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Demo.Website.Controllers;

public sealed class UsersController : BaseApiController
{
	/// <summary>
	/// Custom class map to set the order of the columns manually
	/// </summary>
	private sealed class UserCsvMap : ClassMap<User>
	{
		public UserCsvMap()
		{
			Map(v => v.Id);
			Map(v => v.Created);
			Map(v => v.CreatedBy);
			Map(v => v.Modified);
			Map(v => v.ModifiedBy);
			Map(v => v.FirstName);
			Map(v => v.LastName);
			Map(v => v.DateOfBirth);
			Map(v => v.EmailAddress);
			Map(v => v.Telephone);
		}
	}

	private readonly AppDbContext _context;

	public UsersController(ILogger<UsersController> logger, AppDbContext context) : base(logger)
	{
		_context = context;
	}

	[HttpDelete("{id}")]
	public async Task<IActionResult> DeleteUserAsync(int id, CancellationToken cancellationToken)
	{
		var user = await _context.Users.FirstOrDefaultAsync(v => v.Id == id, cancellationToken);
		if (user == null)
			throw new NotFoundException(nameof(User), id);

		_context.Users.Remove(user);

		await _context.SaveChangesAsync();
		return Ok();
	}

	[HttpGet("csv")]
	public async Task<IActionResult> DownloadCsvAsync(CancellationToken cancellationToken)
	{
		var sw = new StringWriter();
		var config = new CsvConfiguration(CultureInfo.InvariantCulture)
		{
			Delimiter = ","
		};

		using (var writer = new CsvWriter(sw, config))
		{
			writer.Context.RegisterClassMap<UserCsvMap>();
			writer.WriteHeader<User>();
			writer.NextRecord();

			await writer.WriteRecordsAsync(_context.Users, cancellationToken);
		}

		Response.Headers.ContentDisposition = "attachment; filename=\"Users.csv\"";

		return new ContentResult
		{
			Content = sw.ToString(),
			ContentType = "text/csv",
			StatusCode = (int)HttpStatusCode.OK
		};
	}
}
