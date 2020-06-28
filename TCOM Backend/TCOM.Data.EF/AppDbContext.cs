using System;
using System.Linq;
using Microsoft.AspNetCore.Identity;
//using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TCOM.Core.SharedCore;
using TCOM.Data.Entities;

namespace TCOM.Data.EF
{
    public class AppDbContext: DbContext
    {
        public DbSet<Home> Home { get; set; }
        public DbSet<AppRole> AppRole { get; set; }
        public DbSet<Language> Language { get; set; }
        public DbSet<Engagement> Engagement { get; set; }
        public DbSet<AppUser> AppUser { get; set; }
        public DbSet<Permisson> Permisson { get; set; }
        public DbSet<RolePermisson> RolePermisson { get; set; }
        public DbSet<UserRole> UserRole { get; set; }
        public DbSet<ServiceHome> ServiceHome { get; set; }
        public DbSet<Partner> Partner { get; set; }
        public DbSet<Introduction> Introduction { get; set; }
        public DbSet<ProgrammingLanguage> ProgrammingLanguage { get; set; }
        public DbSet<Expertise> Expertise { get; set; }
        public DbSet<Gallery> Gallery { get; set; }
        public DbSet<Contact> Contact { get; set; }
        public DbSet<ServiceTypeDetail> ServiceTypeDetail { get; set; }
        public DbSet<ServiceSubDetail> ServiceSubDetail { get; set; }
        public DbSet<ServiceType> ServiceType { get; set; }
        public DbSet<ProjectType> ProjectType { get; set; }
        public DbSet<Project> Project { get; set; }
        public DbSet<Library> Library { get; set; }
        public DbSet<ProjectTypeDetail> ProjectTypeDetail { get; set; }
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public override int SaveChanges()
        {
            var modifiedEntries = ChangeTracker.Entries()
               .Where(x => x.Entity is IDomainEntity && (x.State == EntityState.Added || x.State == EntityState.Modified));

            foreach (var entry in modifiedEntries)
            {
                var entity = (IDomainEntity)entry.Entity;
                DateTime now = DateTime.Now;

                if (entry.State == EntityState.Added)
                {
                    entity.DateCreated = now;
                }
                else
                {
                    base.Entry(entity).Property(x => x.DateCreated).IsModified = false;
                }

                entity.DateModified = now;
            }
            return base.SaveChanges();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            #region Identity Config

            builder.Entity<IdentityUserClaim<Guid>>().ToTable("AppUserClaims").HasKey(x => x.Id);

            builder.Entity<IdentityRoleClaim<Guid>>().ToTable("AppRoleClaims")
                .HasKey(x => x.Id);

            builder.Entity<IdentityUserLogin<Guid>>().ToTable("AppUserLogins").HasKey(x => x.UserId);

            builder.Entity<IdentityUserRole<Guid>>().ToTable("AppUserRoles")
                .HasKey(x => new { x.RoleId, x.UserId });
            builder.Entity<IdentityUserRole<Guid>>().HasKey(p => new { p.UserId, p.RoleId });

            builder.Entity<IdentityUserToken<Guid>>().ToTable("AppUserTokens")
               .HasKey(x => new { x.UserId });
            #endregion Identity Config
        }
    }
}
