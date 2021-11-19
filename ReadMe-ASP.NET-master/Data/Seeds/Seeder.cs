using AspNetCore.Identity.MongoDbCore.Models;
using Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Seeds
{
    public partial class Seeder
    {
        public async static Task SeedData(IServiceProvider services)
        {
            using(var scope=services.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<Role>>();
                await SeedRoles(roleManager);
            }
        }
    }
}
