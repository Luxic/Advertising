using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace Advertising.Infrastructure.Identity
{
    public class IdentityDbContextSeed
	{
        public static async Task SeedAsync(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            await roleManager.CreateAsync(new IdentityRole("Admin"));

            var defaultUser = new ApplicationUser { UserName = "a@a.a", Email = "h.marjanovic82@gmail.com" };
            await userManager.CreateAsync(defaultUser, "a");

            string adminUserName = "admin@microsoft.com";
            var adminUser = new ApplicationUser { UserName = adminUserName, Email = adminUserName };
            await userManager.CreateAsync(adminUser, "a");
            adminUser = await userManager.FindByNameAsync(adminUserName);
            await userManager.AddToRoleAsync(adminUser, "Admin");
        }
    }
}
