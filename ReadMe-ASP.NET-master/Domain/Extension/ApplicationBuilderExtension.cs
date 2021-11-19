using Data.Seeds;
using Microsoft.AspNetCore.Builder;

namespace Domain.Extension
{
    public static class ApplicationBuilderExtension
    {
        public static void AddSeeder(this IApplicationBuilder app)
        {
            Seeder.SeedData(app.ApplicationServices);
        }
    }
}
