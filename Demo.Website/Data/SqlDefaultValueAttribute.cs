namespace Demo.Website.Data;

/// <summary>
/// Attribute to allow SQL expressions to be used as the default value for columns
/// </summary>
[AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
public class SqlDefaultValueAttribute : Attribute
{
	public string DefaultValue { get; }

	public SqlDefaultValueAttribute(string defaultValue)
	{
		DefaultValue = defaultValue;
	}
}
