using Demo.Website.Entities;
using Demo.Website.Entities.Base;
using Demo.Website.Interfaces;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Demo.Website.Data;

public sealed class AppDbContext : DbContext
{
	private readonly ICurrentUserService _currentUserService;

	public DbSet<User> Users { get; init; }

	public AppDbContext(DbContextOptions<AppDbContext> options, ICurrentUserService currentUserService) : base(options)
	{
		_currentUserService = currentUserService;
	}

	protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
	{
		configurationBuilder.Conventions.Add(sp => ActivatorUtilities.CreateInstance<SqlDefaultValueAttributeConvention>(sp));
		base.ConfigureConventions(configurationBuilder);
	}

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
		base.OnModelCreating(modelBuilder);
	}

	public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
	{
		foreach (var entry in ChangeTracker.Entries<BaseAuditableEntity>())
		{
			switch (entry.State)
			{
				case EntityState.Added:
					entry.Property(v => v.Created).CurrentValue = DateTime.UtcNow;
					entry.Property(v => v.CreatedBy).CurrentValue = _currentUserService.CurrentUser;
					entry.Property(v => v.Modified).IsModified = false;
					entry.Property(v => v.ModifiedBy).IsModified = false;
					break;
				case EntityState.Modified:
					entry.Property(v => v.Created).IsModified = false;
					entry.Property(v => v.CreatedBy).IsModified = false;
					entry.Property(v => v.Modified).CurrentValue = DateTime.UtcNow;
					entry.Property(v => v.ModifiedBy).CurrentValue = _currentUserService.CurrentUser;
					break;
			}
		}

		return base.SaveChangesAsync(cancellationToken);
	}
}
