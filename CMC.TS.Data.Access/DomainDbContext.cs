using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using CMC.TS.UMS.Data.Model;
namespace CMC.TS.UMS.Data.Access
{
    public class DomainDbContext : DbContext
    {
        protected readonly IConfiguration Configuration;
        public DomainDbContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public DomainDbContext(DbContextOptions<DomainDbContext> dbContextOptions) : base(dbContextOptions)
        {
            
        }
        public virtual DbSet<USERS> Users { get; set; }
        public virtual DbSet<ROLES> Roles { get; set; }
        public virtual DbSet<USER_ROLES> User_Roles { get; set; }
        public virtual DbSet<ORGANIZATIONS> Organizations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<USERS>(entity =>
            {
                entity.HasKey(e => e.ID);
            });
            modelBuilder.Entity<USER_ROLES>(entity =>
            {
                entity.HasKey(e => e.ID);
                entity.HasOne(e => e.ROLEs).WithMany(e => e.USER_ROLEs).HasForeignKey(e => e.ROLE_ID);
                entity.HasOne(e => e.USERs).WithMany(e => e.USER_ROLEs).HasForeignKey(e => e.ROLE_ID);

            });
            modelBuilder.Entity<ORGANIZATIONS>(entity =>
            {
                entity.HasKey(e => e.ID);
                entity.HasIndex(e => e.CODE).IsUnique();

            });
            modelBuilder.Entity<ROLES>(entity =>
            {
                entity.HasKey(e => e.ID);

            });
        }
    }
}
