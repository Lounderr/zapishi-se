namespace ZapishiSe.Data
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Threading;
    using System.Threading.Tasks;

    using ZapishiSe.Data.Common.Models;
    using ZapishiSe.Data.Models;

    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    using System.Reflection.Emit;
    using System.Reflection.Metadata;
    using System.Diagnostics.Metrics;

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, string>
    {
        private static readonly MethodInfo SetIsDeletedQueryFilterMethod =
            typeof(ApplicationDbContext).GetMethod(
                nameof(SetIsDeletedQueryFilter),
                BindingFlags.NonPublic | BindingFlags.Static);

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Setting> Settings { get; set; }

        public DbSet<BusinessCategory> BusinessCategories { get; set; }


        public DbSet<Business> Businesses { get; set; }

        public DbSet<Service> Services { get; set; }

        public DbSet<BookedAppointment> BookedAppointments { get; set; }

        public DbSet<BusinessImage> BusinessImages { get; set; }


        public DbSet<OpenHours> OpenHours { get; set; }

        public DbSet<Break> Breaks { get; set; }

        public DbSet<Holiday> Holidays { get; set; }

        public DbSet<BusinessPromotion> BusinessPromotions { get; set; }

        public DbSet<VisitsEachMonth> VisitsEachMonths { get; set; }

        public DbSet<UserReport> UserReports { get; set; }

        public DbSet<ReviewReport> ReviewReports { get; set; }

        public DbSet<BusinessReport> BusinessReports { get; set; }

        public DbSet<Review> Reviews { get; set; }

        public DbSet<ReviewInteraction> ReviewInteractions { get; set; }

        public DbSet<Conversation> Conversations { get; set; }

        public DbSet<Message> Messages { get; set; }

        public override int SaveChanges() => this.SaveChanges(true);

        public override int SaveChanges(bool acceptAllChangesOnSuccess)
        {
            this.ApplyAuditInfoRules();
            return base.SaveChanges(acceptAllChangesOnSuccess);
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default) =>
            this.SaveChangesAsync(true, cancellationToken);

        public override Task<int> SaveChangesAsync(
            bool acceptAllChangesOnSuccess,
            CancellationToken cancellationToken = default)
        {
            this.ApplyAuditInfoRules();
            return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            // -- Custom Models --
            builder.Entity<ApplicationUser>()
                .HasMany(e => e.Businesses)
                .WithOne(e => e.Owner);

            builder.Entity<ApplicationUser>()
                .HasMany(e => e.AuthoredUserReports)
                .WithOne(e => e.Author);

            builder.Entity<ApplicationUser>()
                .HasMany(e => e.UserReports)
                .WithOne(e => e.TargetUser);

            //builder.Entity<BookedAppointment>()
            //    .HasOne(a => a.Service)
            //    .WithOne(a => a.BookedAppointment)
            //    .HasForeignKey<Service>(c => c.Id);


            // -- Custom Models End --

            // Needed for Identity models configuration
            base.OnModelCreating(builder);

            this.ConfigureUserIdentityRelations(builder);

            EntityIndexesConfiguration.Configure(builder);

            var entityTypes = builder.Model.GetEntityTypes().ToList();

            // Set global query filter for not deleted entities only
            var deletableEntityTypes = entityTypes
                .Where(et => et.ClrType != null && typeof(IDeletableEntity).IsAssignableFrom(et.ClrType));
            foreach (var deletableEntityType in deletableEntityTypes)
            {
                var method = SetIsDeletedQueryFilterMethod.MakeGenericMethod(deletableEntityType.ClrType);
                method.Invoke(null, new object[] { builder });
            }

            // Disable cascade delete
            var foreignKeys = entityTypes
                .SelectMany(e => e.GetForeignKeys().Where(f => f.DeleteBehavior == DeleteBehavior.Cascade));
            foreach (var foreignKey in foreignKeys)
            {
                foreignKey.DeleteBehavior = DeleteBehavior.Restrict;
            }
        }

        private static void SetIsDeletedQueryFilter<T>(ModelBuilder builder)
            where T : class, IDeletableEntity
        {
            builder.Entity<T>().HasQueryFilter(e => !e.IsDeleted);
        }

        // Applies configurations
        private void ConfigureUserIdentityRelations(ModelBuilder builder)
             => builder.ApplyConfigurationsFromAssembly(this.GetType().Assembly);

        private void ApplyAuditInfoRules()
        {
            var changedEntries = this.ChangeTracker
                .Entries()
                .Where(e =>
                    e.Entity is IAuditInfo &&
                    (e.State == EntityState.Added || e.State == EntityState.Modified));

            foreach (var entry in changedEntries)
            {
                var entity = (IAuditInfo)entry.Entity;
                if (entry.State == EntityState.Added && entity.CreatedOn == default)
                {
                    entity.CreatedOn = DateTime.UtcNow;
                }
                else
                {
                    entity.ModifiedOn = DateTime.UtcNow;
                }
            }
        }
    }
}
