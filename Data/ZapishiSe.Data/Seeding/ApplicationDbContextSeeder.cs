namespace ZapishiSe.Data.Seeding
{
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Hosting;
    using Microsoft.Extensions.Logging;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class ApplicationDbContextSeeder : ISeeder
    {
        private readonly IHostEnvironment hostEnvironment;

        public ApplicationDbContextSeeder(IHostEnvironment hostEnvironment)
        {
            this.hostEnvironment = hostEnvironment;
        }

        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext == null)
            {
                throw new ArgumentNullException(nameof(dbContext));
            }

            if (serviceProvider == null)
            {
                throw new ArgumentNullException(nameof(serviceProvider));
            }

            var logger = serviceProvider.GetService<ILoggerFactory>().CreateLogger(typeof(ApplicationDbContextSeeder));

            var seeders = new List<ISeeder>
            {
                new RolesSeeder(),
                new SettingsSeeder(),
            };

            if (hostEnvironment.IsDevelopment())
            {
                seeders.Add(new ApplicationUsersSeeder());
                seeders.Add(new MockDataSeeder());
            }

            foreach (var seeder in seeders)
            {
                await seeder.SeedAsync(dbContext, serviceProvider);
                await dbContext.SaveChangesAsync();
                logger.LogInformation($"Seeder {seeder.GetType().Name} done.");
            }
        }
    }
}
