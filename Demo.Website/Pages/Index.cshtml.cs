using Demo.Website.Data;
using Demo.Website.Entities;

using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Demo.Website.Pages
{
	public class IndexModel : PageModel
	{
		private readonly ILogger<IndexModel> _logger;
		private readonly AppDbContext _context;

		public IReadOnlyList<User> Users { get; private set; } = Array.Empty<User>();

		public IndexModel(ILogger<IndexModel> logger, AppDbContext context)
		{
			_logger = logger;
			_context = context;
		}

		public async Task OnGetAsync(CancellationToken cancellationToken)
		{
			Users = await _context.Users.ToArrayAsync(cancellationToken);
		}
	}
}