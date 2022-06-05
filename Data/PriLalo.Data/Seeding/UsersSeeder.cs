namespace PriLalo.Data.Seeding
{
    using System;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Identity;
    using Microsoft.Extensions.DependencyInjection;
    using PriLalo.Common;
    using PriLalo.Data;
    using PriLalo.Data.Models;

    public class UsersSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            var userManager = serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();

            await SeedUserAsync(userManager, "pastaworld@abv.bg");
            await SeedUserAsync(userManager, "tzl_bul@yahoo.com");
            await SeedUserAsync(userManager, "delivery@abv.bg");
            await SeedUserAsync(userManager, "chef@abv.bg");
            await SeedUserAsync(userManager, "bartender@abv.bg");
        }

        private static async Task SeedUserAsync(UserManager<ApplicationUser> userManager, string userName)
        {
            var user = await userManager.FindByNameAsync(userName);
            if (user == null)
            {
                var appUser = new ApplicationUser();
                appUser.UserName = userName;
                appUser.Email = userName;

                IdentityResult result = new IdentityResult();

                if (userName == "pastaworld@abv.bg")
                {
                    result = userManager.CreateAsync(appUser, "pasta#18boss").Result;
                }
                else if (userName == "tzl_bul@yahoo.com")
                {
                    result = userManager.CreateAsync(appUser, "trqvna@83da").Result;
                }
                else if (userName == "delivery@abv.bg")
                {
                    result = userManager.CreateAsync(appUser, "del12f").Result;
                }
                else if (userName == "chef@abv.bg")
                {
                    result = userManager.CreateAsync(appUser, "chef2d").Result;
                }
                else if (userName == "bartender@abv.bg")
                {
                    result = userManager.CreateAsync(appUser, "bar816").Result;
                }

                if (result.Succeeded)
                {
                    if (userName == "pastaworld@abv.bg" || userName == "tzl_bul@yahoo.com")
                    {
                        userManager.AddToRoleAsync(appUser, GlobalConstants.AdministratorRoleName).Wait();
                    }
                    else if (userName == "delivery@abv.bg")
                    {
                        userManager.AddToRoleAsync(appUser, GlobalConstants.DeliveryManRoleName).Wait();
                    }
                    else if (userName == "chef@abv.bg")
                    {
                        userManager.AddToRoleAsync(appUser, GlobalConstants.ChefRoleName).Wait();
                    }
                    else if (userName == "bartender@abv.bg")
                    {
                        userManager.AddToRoleAsync(appUser, GlobalConstants.BartenderRoleName).Wait();
                    }
                }
            }
        }
    }
}
