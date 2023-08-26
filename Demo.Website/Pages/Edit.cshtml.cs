using Demo.Application.Users.Commands;
using Demo.Website.Data;
using Demo.Website.Entities;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Demo.Website.Pages
{
	public class EditModel : PageModel
	{
		private readonly ILogger<EditModel> _logger;
		private readonly AppDbContext _context;

		[BindProperty]
		public UserModel Value { get; set; } = null!;

		public EditModel(ILogger<EditModel> logger, AppDbContext context)
		{
			_logger = logger;
			_context = context;
		}

		public async Task<IActionResult> OnGetAsync([FromRoute] int? id, CancellationToken cancellationToken)
		{
			if (id == null)
			{
				Value = new UserModel();
			}
			else
			{
				var user = await _context.Users.FirstOrDefaultAsync(v => v.Id == id, cancellationToken);
				if (user == null)
				{
					_logger.LogWarning("User not found: {id}", id);
					return Redirect("/Index");
				};

				Value = new UserModel
				{
					FirstName = user.FirstName,
					LastName = user.LastName,
					DateOfBirth = user.DateOfBirth,
					EmailAddress = user.EmailAddress,
					Telephone = user.Telephone
				};
			}

			return Page();
		}

		public async Task<IActionResult> OnPostAsync([FromRoute] int? id, CancellationToken cancellationToken)
		{
			if (!ModelState.IsValid)
				return Page();

			var user = new User
			{
				FirstName = Value.FirstName,
				LastName = Value.LastName,
				DateOfBirth = Value.DateOfBirth,
				EmailAddress = Value.EmailAddress,
				Telephone = Value.Telephone
			};

            if (id == null)
            {
				await _context.AddAsync(user, cancellationToken);
			}
			else
			{
				user.Id = (int)id;
				_context.Update(user);
			}

			await _context.SaveChangesAsync(cancellationToken);

			return Redirect("/Index");
		}
	}
}
