using ayush.Data;
using ayush.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;

public static class CreateRolesOnStartup
{
	public static void SeedData
	(UserManager<IdentityUser> userManager,
	RoleManager<IdentityRole> roleManager,
	ayushContext context)
	{
		SeedRoles(roleManager);
		SeedUsers(userManager);
		SeedSystemSettings(context);
		SeedPlans(context);
	}

	private static void SeedPlans(ayushContext context)
	{
		if(context.Plans.Any() == false)
		{
			context.Plans.Add(new Plan() { Name = "Tier 1" });
			context.Plans.Add(new Plan() { Name = "Tier 2" });
			context.Plans.Add(new Plan() { Name = "Tier 3" });
			context.SaveChanges();
		}
	}

	private static void SeedSystemSettings(ayushContext context)
	{
		if (context.SystemInformation.Any() == false)
		{
			List<SystemInformation> settings = new List<SystemInformation>()
			{
				new SystemInformation()
				{
					PropertyName = "Name",
					PropertyValue = "UPCLASS"
				},
				new SystemInformation()
				{
					PropertyName = "Address",
								PropertyValue = "UPCLASS"
				},
				new SystemInformation()
				{
					PropertyName = "Email",
								PropertyValue = "UPCLASS"
				},
				new SystemInformation()
				{
					PropertyName = "PhoneNumber1",
								PropertyValue = "UPCLASS"
				},
				new SystemInformation()
				{
					PropertyName = "PhoneNumber2",
								PropertyValue = "UPCLASS"
				}
			};

			context.AddRange(settings);

			context.SaveChanges();
		}

	}

	public static void SeedUsers
	(UserManager<IdentityUser> userManager)
	{
		if (userManager.FindByNameAsync
	("admin").Result == null)
		{
			IdentityUser user = new IdentityUser
			{
				UserName = "admin",
				Email = "upclassed@gmail.com",
				PhoneNumber = "8803631033",
				TwoFactorEnabled = false,
				EmailConfirmed = true
			};

			IdentityResult result = userManager.CreateAsync
			(user, "Admin@123").Result;

			if (result.Succeeded)
			{
				userManager.AddToRoleAsync(user, "Admin").Wait();
			}
		}

	}

	public static void SeedRoles
	(RoleManager<IdentityRole> roleManager)
	{
		if (!roleManager.RoleExistsAsync
	("Admin").Result)
		{
			IdentityRole role = new IdentityRole();
			role.Name = "Admin";
			// role.Description = "Perform normal operations.";
			IdentityResult roleResult = roleManager.
			CreateAsync(role).Result;
		}


		if (!roleManager.RoleExistsAsync
	("Student").Result)
		{
			IdentityRole role = new IdentityRole();
			role.Name = "Student";
			//role.Description = "Perform all the operations.";
			IdentityResult roleResult = roleManager.
			CreateAsync(role).Result;
		}

		if (!roleManager.RoleExistsAsync
	("Counsellor").Result)
		{
			IdentityRole role = new IdentityRole();
			role.Name = "Counsellor";
			//role.Description = "Perform all the operations.";
			IdentityResult roleResult = roleManager.
			CreateAsync(role).Result;
		}

		if (!roleManager.RoleExistsAsync
	("School").Result)
		{
			IdentityRole role = new IdentityRole();
			role.Name = "School";
			//role.Description = "Perform all the operations.";
			IdentityResult roleResult = roleManager.
			CreateAsync(role).Result;
		}
	}
}