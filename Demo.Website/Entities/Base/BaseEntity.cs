using System.ComponentModel.DataAnnotations.Schema;

using Microsoft.EntityFrameworkCore;

namespace Demo.Website.Entities.Base;

[PrimaryKey(nameof(Id))]
public abstract record BaseEntity
{
	[Column(Order = 0)]
	public int Id { get; set; }
}
