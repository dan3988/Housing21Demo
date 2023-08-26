using System.ComponentModel.DataAnnotations;

using Demo.Website.Entities.Base;

namespace Demo.Website.Entities;

public sealed record User : BaseAuditableEntity
{
	[Required, MaxLength(50)]
	public required string FirstName { get; set; }

	[Required, MaxLength(50)]
	public required string LastName { get; set; }

	[Required]
	public required DateOnly DateOfBirth { get; set; }

	[Required, MaxLength(255)]
	public required string Telephone { get; set; }

	[Required, MaxLength(255)]
	public required string EmailAddress { get; set; }
}
