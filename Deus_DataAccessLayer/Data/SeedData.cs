using Deus_Models.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deus_DataAccessLayer.Data
{
    public static class SeedData
    {
        public async static Task Seed(UserManager<ApplicationOwner> userManager,
           RoleManager<IdentityRole> roleManager)
        {
            await SeedRoles(roleManager);
            await SeedUsers(userManager);
        }
        private async static Task SeedUsers(UserManager<ApplicationOwner> userManager)
        {
            if (await userManager.FindByEmailAsync("admin@barbershop.com") == null)
            {
                var user = new ApplicationOwner
                {
                    FirstName = "Dionisis",
                    LastName = "Tocila",
                    PhoneNumber = "2102725253",
                    UserName = "deusbarbershop@deusbarbershop.gr",
                    Email = "deusbarbershop@deusbarbershop.gr"
                };
                var result = await userManager.CreateAsync(user, "Pwd123");
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(user, "Administrator");
                }
            }
        }
        private async static Task SeedRoles(RoleManager<IdentityRole> roleManager)
        {
            
            if (!await roleManager.RoleExistsAsync("Administrator"))
            {
                var role = new IdentityRole
                {
                    Name = "Administrator"
                };
               
                await roleManager.CreateAsync(role);
            }

            if (!await roleManager.RoleExistsAsync("Customer"))
            {
                var role = new IdentityRole
                {
                    Name = "Customer"
                };
                await roleManager.CreateAsync(role);
            }
        }
    }
}
