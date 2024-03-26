using Microsoft.EntityFrameworkCore;
using Domain.Features.Identity.Users;
using Domain.Features.Identity.Users.Enums;

namespace Persistence.Features.Identity;

internal class UserConfiguration : object, IEntityTypeConfiguration<User>
{
	public UserConfiguration() : base()
	{
	}

	public void Configure(Microsoft.EntityFrameworkCore
		.Metadata.Builders.EntityTypeBuilder<User> builder)
	{
		// **************************************************
		// **************************************************
		// **************************************************
		builder
			.HasKey(current => current.Id)
			// مهم
			// https://www.youtube.com/watch?v=n17U7ntLMt4&t=803s
			.IsClustered(clustered: false)
			;
		// **************************************************

		// **************************************************
		builder
			.Property(current => current.Username)
			.IsUnicode(unicode: false)
			;

		builder
			.HasIndex(current => new { current.Username })
			.IsUnique(unique: true)
			;
		// **************************************************

		// **************************************************
		builder
			.Property(current => current.Password)
			.IsUnicode(unicode: false)
			;
		// **************************************************

		// **************************************************
		builder
			.HasIndex(current => new { current.FullName })
			.IsUnique(unique: false)
			;
		// **************************************************
		// **************************************************
		// **************************************************

		// **************************************************
		// *** Seed Data ************************************
		// **************************************************
		var user =
			new User
			(username: "Dariush",
			password: "1234512345",
			role: Role.Administrator)
			{
				IsActive = true,
				Description = null,
				FullName = "Mr. Dariush Tasdighi",
			};

		builder.HasData(data: user);
		// **************************************************
		// **************************************************
		// **************************************************
	}
}
