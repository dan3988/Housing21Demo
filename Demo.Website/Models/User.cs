using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

using FluentValidation;

namespace Demo.Application.Users.Commands;

public sealed record UserModel
{
	public string FirstName { get; set; } = "";

	public string LastName { get; set; } = "";

	[DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
	public DateOnly DateOfBirth { get; set; } = new DateOnly(2000, 1, 1);

	public string EmailAddress { get; set; } = "";

    public string Telephone { get; set; } = "";
}

public sealed class UserModelValidator : AbstractValidator<UserModel>
{
	/// <summary>
	/// Validates that a phone number that starts with either "+44" or "0", followed by 9-12 digits, allowing whitespace between numbers
	/// </summary>
	[StringSyntax("Regex")]
	private const string UkTelephoneRegex = @"(?:0|\+44)(?:\d\s?){9,12}$";

	public UserModelValidator()
	{
		RuleFor(v => v.FirstName).NotEmpty()
			.WithMessage("First name is required.")
			.MinimumLength(2)
			.WithMessage("First name must be between 2 and 50 characters long.")
			.MaximumLength(50)
			.WithMessage("First name must be between 2 and 50 characters long.");

		RuleFor(v => v.LastName).NotEmpty()
			.WithMessage("Last name is required.")
			.MinimumLength(2)
			.WithMessage("Last name must be between 2 and 50 characters long.")
			.MaximumLength(50)
			.WithMessage("Last name must be between 2 and 50 characters long.");

		RuleFor(v => v.DateOfBirth)
			.LessThanOrEqualTo(_ => DateOnly.FromDateTime(DateTime.UtcNow))
			.WithMessage("Date of Birth cannot be in the future.");

		RuleFor(v => v.EmailAddress).NotEmpty()
			.WithMessage("Email address required.")
			.EmailAddress()
			.WithMessage("Invalid email address.");

		RuleFor(v => v.Telephone)
			.Matches(UkTelephoneRegex)
			.WithMessage("Invalid telephone number.");
	}
}