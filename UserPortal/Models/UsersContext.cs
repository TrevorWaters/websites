using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace UserPortal.Models
{
    public partial class UsersContext : DbContext
    {

        public UsersContext(DbContextOptions<UsersContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserRole> UserRoles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("Name=Users");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>(entity =>
            {
                entity.HasIndex(e => e.RoleId, "IX_Roles_RoleId")
                    .IsUnique();

                entity.Property(e => e.RoleName).IsRequired();
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasIndex(e => e.UserId, "IX_Users_UserId")
                    .IsUnique();

                entity.Property(e => e.AgencyAddress).IsRequired();

                entity.Property(e => e.AgencyCity).IsRequired();

                entity.Property(e => e.AgencyName).IsRequired();

                entity.Property(e => e.AgencyZipCode).IsRequired();

                entity.Property(e => e.EmailAddress).IsRequired();

                entity.Property(e => e.FirstName).IsRequired();

                entity.Property(e => e.JobTitle).IsRequired();

                entity.Property(e => e.LastName).IsRequired();

                entity.Property(e => e.WorkPhone).IsRequired();
            });

            modelBuilder.Entity<UserRole>(entity =>
            {
                entity.HasIndex(e => e.UserRoleId, "IX_UserRoles_UserRoleId")
                    .IsUnique();

                entity.Property(e => e.IsAims)
                    .IsRequired()
                    .HasColumnType("NUMERIC")
                    .HasColumnName("IsAIMS");

                entity.Property(e => e.IsApproved)
                    .IsRequired()
                    .HasColumnType("NUMERIC")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsCw)
                    .IsRequired()
                    .HasColumnType("NUMERIC")
                    .HasColumnName("IsCW");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
