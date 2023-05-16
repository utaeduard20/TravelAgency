using Microsoft.AspNetCore.Identity;
using System;
using System.Threading.Tasks;
using TravelAgencyTest.Models;

namespace TravelAgencyTest.Data
{
    public class DummyData
    {
        public static async Task Initialize(ApplicationDbContext context,
                              UserManager<ApplicationUser> userManager,
                              RoleManager<ApplicationRole> roleManager)
        {
            context.Database.EnsureCreated();

            String adminId1 = "";
            String adminId2 = "";

            string role1 = "Admin";

            string role2 = "User";

            string password = "Abc123-";

            if (await roleManager.FindByNameAsync(role1) == null)
            {
                await roleManager.CreateAsync(new ApplicationRole(role1, DateTime.Now));
            }
            if (await roleManager.FindByNameAsync(role2) == null)
            {
                await roleManager.CreateAsync(new ApplicationRole(role2, DateTime.Now));
            }

            if (await userManager.FindByNameAsync("ionion") == null)
            {
                var user = new ApplicationUser
                {
                    UserName = "ionion",
                    Email = "ion@ion.com",
                    FirstName = "Ion",
                    LastName = "Ion",
                    Age = "25",
                    Country = "Bold",
                    PhoneNumber = "6902341234"
                };

                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, password);
                    await userManager.AddToRoleAsync(user, role1);
                }
                adminId1 = user.Id;
            }

            if (await userManager.FindByNameAsync("eu") == null)
            {
                var user = new ApplicationUser
                {
                    UserName = "eu",
                    Email = "eu@gmail.com",
                    FirstName = "Bob",
                    LastName = "Barker",
                    Age = "25",
                    Country = "Canada",
                    PhoneNumber = "7788951456"
                };

                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, password);
                    await userManager.AddToRoleAsync(user, role1);
                }
                adminId2 = user.Id;
            }

            if (await userManager.FindByNameAsync("marian") == null)
            {
                var user = new ApplicationUser
                {
                    UserName = "marian",
                    Email = "mm@mm.mm",
                    FirstName = "Mike",
                    LastName = "Myers",
                    Age = "25",
                    Country = "Canada",
                    PhoneNumber = "6572136821"
                };

                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, password);
                    await userManager.AddToRoleAsync(user, role2);
                }
            }

            if (await userManager.FindByNameAsync("mancas") == null)
            {
                var user = new ApplicationUser
                {
                    UserName = "mancas",
                    Email = "dd@dd.dd",
                    FirstName = "Donald",
                    LastName = "Duck",
                    Age = "25",
                    Country = "Canada",
                    PhoneNumber = "6041234567"
                };

                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, password);
                    await userManager.AddToRoleAsync(user, role2);
                }
            }
        }
    }
}
