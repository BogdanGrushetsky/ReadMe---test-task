using AspNetCore.Identity.MongoDbCore.Models;
using Data.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Seeds
{
    public partial class Seeder
    {
        private async static Task SeedRoles(RoleManager<Role> roleManager)
        {
            if (!roleManager.Roles.Any())
            {
                var user = new Role() { Name = "participant" };
                await roleManager.CreateAsync(user);
            }
        }
    }
}
