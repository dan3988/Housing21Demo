using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Demo.Website.Data;

internal sealed class DateOnlyConverter : ValueConverter<DateOnly, DateTime>
{
	public static readonly DateOnlyConverter Instance = new();

	private DateOnlyConverter() : base(v => v.ToDateTime(default), v => DateOnly.FromDateTime(v))
	{
	}
}
