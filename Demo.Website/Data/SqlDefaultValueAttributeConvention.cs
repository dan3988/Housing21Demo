using System.Reflection;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace Demo.Website.Data;

public class SqlDefaultValueAttributeConvention : PropertyAttributeConventionBase<SqlDefaultValueAttribute>
{
	public SqlDefaultValueAttributeConvention() : base(null!)
	{
	}

	protected override void ProcessPropertyAdded(IConventionPropertyBuilder propertyBuilder, SqlDefaultValueAttribute attribute, MemberInfo clrMember, IConventionContext context)
	{
		propertyBuilder.HasDefaultValueSql(attribute.DefaultValue);
	}
}