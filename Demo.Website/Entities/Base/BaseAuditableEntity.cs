using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using Demo.Website.Data;

namespace Demo.Website.Entities.Base;

public abstract record BaseAuditableEntity : BaseEntity
{
	[Column(Order = 1), Required, SqlDefaultValue("GETDATE()")]
	public DateTime Created { get; private set; }

	[Column(Order = 2), Required, MaxLength(255), SqlDefaultValue("CURRENT_USER")]
	public string? CreatedBy { get; private set; }

	[Column(Order = 3)]
	public DateTime? Modified { get; private set; }

	[Column(Order = 4), MaxLength(255)]
	public string? ModifiedBy { get; private set; }
}
