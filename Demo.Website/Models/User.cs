using System.ComponentModel.DataAnnotations;

namespace Demo.Application.Users.Commands;

public sealed record UserModel
{
	public string FirstName { get; set; } = "";

	public string LastName { get; set; } = "";

	[DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
	public DateOnly DateOfBirth { get; set; } = new DateOnly(2000, 1, 1);

	public string EmailAddress { get; set; } = "";

    public string Telephone { get; set; } = "";
}
