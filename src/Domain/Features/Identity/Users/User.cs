using System.ComponentModel;
using Domain.Features.Identity.Users.Enums;
using System.ComponentModel.DataAnnotations;

namespace Domain.Features.Identity.Users;

public class User(string username, string password, Role role) : Seedwork.Entity
{
	[MaxLength(length: 20)]
	[Required(AllowEmptyStrings = false)]
	public string Username { get; set; } = username;

	[MaxLength(length: 40)]
	[Browsable(browsable: false)]
	[Required(AllowEmptyStrings = false)]
	public string Password { get; set; } = password;

	public Role Role { get; set; } = role;

	[DisplayName(displayName: "Active")]
	public bool IsActive { get; set; }

	[MaxLength(length: 50)]
	[DisplayName(displayName: "Full Name")]
	public string? FullName { get; set; }

	[Browsable(browsable: false)]
	public string? Description { get; set; }
}
