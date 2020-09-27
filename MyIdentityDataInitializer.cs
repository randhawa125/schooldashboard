public static class MyIdentityDataInitializer
{
    public static void SeedData
    (UserManager<IdentityUser> userManager,
    RoleManager<IdentityRole> roleManager)
    {
        SeedRoles(roleManager);
        SeedUsers(userManager);
    }

    public static void SeedUsers
    (UserManager<IdentityUser> userManager)
    {
        if (userManager.FindByNameAsync
    ("user1").Result == null)
        {
            IdentityUser user = new IdentityUser();
            user.UserName = "user1";
            user.Email = "user1@localhost";
            user.FullName = "Nancy Davolio";
            user.BirthDate = new DateTime(1960, 1, 1);

            IdentityResult result = userManager.CreateAsync
            (user, "password_goes_here").Result;

            if (result.Succeeded)
            {
                userManager.AddToRoleAsync(user,
                                    "NormalUser").Wait();
            }
        }


        if (userManager.FindByNameAsync
    ("user2").Result == null)
        {
            IdentityUser user = new IdentityUser();
            user.UserName = "user2";
            user.Email = "user2@localhost";
            user.FullName = "Mark Smith";
            user.BirthDate = new DateTime(1965, 1, 1);

            IdentityResult result = userManager.CreateAsync
            (user, "password_goes_here").Result;

            if (result.Succeeded)
            {
                userManager.AddToRoleAsync(user,
                                    "Administrator").Wait();
            }
        }
    }

    public static void SeedRoles
    (RoleManager<IdentityRole> roleManager)
    {
        if (!roleManager.RoleExistsAsync
    ("NormalUser").Result)
        {
            IdentityRole role = new IdentityRole();
            role.Name = "NormalUser";
            role.Description = "Perform normal operations.";
            IdentityResult roleResult = roleManager.
            CreateAsync(role).Result;
        }


        if (!roleManager.RoleExistsAsync
    ("Administrator").Result)
        {
            IdentityRole role = new IdentityRole();
            role.Name = "Administrator";
            role.Description = "Perform all the operations.";
            IdentityResult roleResult = roleManager.
            CreateAsync(role).Result;
        }
    }
}