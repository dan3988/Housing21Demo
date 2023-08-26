using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Demo.Website.Data;

internal static class EntityFrameworkExtensions
{
	/// <summary>
	/// Set the correct column type and add <see cref="DateTime"/> conversion since <see cref="DateOnly"/> is not supported by entity framework.
	/// </summary>
	public static PropertyBuilder<DateOnly> FixDataType(this PropertyBuilder<DateOnly> property)
		=> property.HasColumnType("date").HasConversion(DateOnlyConverter.Instance);
}
