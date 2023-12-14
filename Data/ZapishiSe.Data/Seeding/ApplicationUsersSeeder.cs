namespace ZapishiSe.Data.Seeding
{
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.Extensions.DependencyInjection;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using ZapishiSe.Data.Models;

    internal class ApplicationUsersSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext context, IServiceProvider serviceProvider)
        {
            var user = new ApplicationUser
            {
                FirstName = "Георги",
                LastName = "Георгиев",
                Email = "example@example.com",
                NormalizedEmail = "EXAMPLE@EXAMPLE.COM",
                UserName = "Example",
                NormalizedUserName = "EXAMPLE",
                PhoneNumber = "+111111111111",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString("D"),
            };

            await context.Users.AddAsync(user);
        }
    }
}
