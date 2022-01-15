using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using RejAndOlej.DATABASE.Models;
using RejAndOlej.Models;

#nullable disable

namespace RejAndOlej.DATABASE
{
    public partial class RejAndOlejContext : DbContext
    {
        public RejAndOlejContext()
        {
        }

        public RejAndOlejContext(DbContextOptions<RejAndOlejContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BusFleet> BusFleets { get; set; }
        public virtual DbSet<BusMaker> BusMakers { get; set; }
        public virtual DbSet<OilCheck> OilChecks { get; set; }
        public virtual DbSet<RegistrationCheck> RegistrationChecks { get; set; }
        public virtual DbSet<Bus> Buses { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserGroup> UserGroups { get; set; }
        public virtual DbSet<UserPermission> UserPermissions { get; set; }
        public virtual DbSet<ConnectionGroupsPermissions> ConnectionsGroupsPermissions { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-KJG8KIQ\\SQLEXPRESS;Database=RejAndOlej;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Cyrillic_General_CI_AS");

            modelBuilder.Entity<BusFleet>(entity =>
            {
                entity.HasKey(e => e.FleetVehicleId);

                entity.ToTable("BusFleet");

                entity.Property(e => e.FleetVehicleId)
                    .ValueGeneratedNever()
                    .HasColumnName("fleetVehicleID");

                entity.Property(e => e.BusId).HasColumnName("busID");

                entity.Property(e => e.DateOfEnterToFleet)
                    .HasColumnType("datetime")
                    .HasColumnName("dateOfEnterToFleet");

                entity.Property(e => e.Mileage).HasColumnName("mileage");

                entity.Property(e => e.RaceNumber)
                    .HasMaxLength(10)
                    .HasColumnName("raceNumber")
                    .IsFixedLength(true);

                entity.Property(e => e.RegistrationNumber)
                    .HasMaxLength(10)
                    .HasColumnName("registrationNumber")
                    .IsFixedLength(true);

                entity.Property(e => e.OilCheckStatus).HasColumnType("smallint").HasColumnName("oilCheckStatus").IsRequired(false);

                entity.Property(e => e.RegCheckStatus).HasColumnType("smallint").HasColumnName("regCheckStatus").IsRequired(false);

                entity.HasOne(d => d.Bus)
                    .WithMany(p => p.BusFleets)
                    .HasForeignKey(d => d.BusId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_BusFleet_Buses");
            });

            modelBuilder.Entity<BusMaker>(entity =>
            {
                entity.Property(e => e.BusMakerId)
                    .ValueGeneratedNever()
                    .HasColumnName("busMakerID");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");

                entity.Property(e => e.Nation)
                    .HasMaxLength(10)
                    .HasColumnName("nation")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<OilCheck>(entity =>
            {
                entity.Property(e => e.OilCheckId)
                    .ValueGeneratedNever()
                    .HasColumnName("oilCheckID");

                entity.Property(e => e.DateOfOilCheck)
                    .HasColumnType("datetime")
                    .HasColumnName("dateOfOilCheck");

                entity.Property(e => e.FleetVechicleId).HasColumnName("fleetVechicleID");

                entity.Property(e => e.MileageOnOilCheck).HasColumnName("mileageOnOilCheck");

                entity.HasOne(d => d.FleetVechicle)
                    .WithMany(p => p.OilChecks)
                    .HasForeignKey(d => d.FleetVechicleId)
                    .HasConstraintName("FK_OilChecks_BusFleet");
            });

            modelBuilder.Entity<RegistrationCheck>(entity =>
            {
                entity.HasKey(e => e.RegCheckId);

                entity.Property(e => e.RegCheckId)
                    .ValueGeneratedNever()
                    .HasColumnName("regCheckID");

                entity.Property(e => e.DateOfRegCheck)
                    .HasColumnType("datetime")
                    .HasColumnName("dateOfRegCheck");

                entity.Property(e => e.FleetVehicleId).HasColumnName("fleetVehicleID");

                entity.Property(e => e.MileageOnRegCheck).HasColumnName("mileageOnRegCheck");

                entity.HasOne(d => d.FleetVehicle)
                    .WithMany(p => p.RegistrationChecks)
                    .HasForeignKey(d => d.FleetVehicleId)
                    .HasConstraintName("FK_RegistrationChecks_BusFleet");
            });

            modelBuilder.Entity<Bus>(entity =>
            {
                entity.Property(e => e.BusId)
                    .ValueGeneratedNever()
                    .HasColumnName("busID");

                entity.Property(e => e.BusMakerId).HasColumnName("busMakerID");

                entity.Property(e => e.DefaultDaysToRegistrationReview).HasColumnName("defaultDaysToRegistrationReview");

                entity.Property(e => e.DefaultKmToOilInspection).HasColumnName("defaultKmToOilInspection");

                entity.Property(e => e.ModelName)
                    .HasMaxLength(50)
                    .HasColumnName("modelName");

                entity.HasOne(d => d.BusMaker)
                    .WithMany(p => p.Buses)
                    .HasForeignKey(d => d.BusMakerId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Buses_BusMakers");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("Users");

                entity.HasKey(e => e.UserId);

                entity.Property(e => e.UserId).HasColumnName("userId");

                entity.Property(e => e.Name).HasMaxLength(10).HasColumnName("name");

                entity.Property(e => e.Surname).HasMaxLength(10).HasColumnName("surname");

                entity.Property(e => e._userGroup).HasColumnName("userGroup").IsRequired(false);

                entity.Property(e => e.Position).HasColumnName("position").IsRequired(false);

                entity.Property(e => e.Login).HasMaxLength(10).HasColumnName("login");

                entity.Property(e => e.Password).HasMaxLength(10).HasColumnName("password");
            });

            modelBuilder.Entity<UserGroup>(entity =>
            {
                entity.ToTable("UserGroups");

                entity.HasKey(e => e.GroupId);

                entity.Property(e => e.GroupId).HasColumnName("groupId");

                entity.Property(e => e.Name).HasColumnName("name").IsRequired(false);

            });

            modelBuilder.Entity<UserPermission>(entity =>
            {
                entity.ToTable("UserPermissions");

                entity.HasKey(e => e.PermissionId);

                entity.Property(e => e.PermissionId).HasColumnName("permissionId");

                entity.Property(e => e.Name).HasColumnName("name").HasColumnType("varchar(50)").IsRequired(false);

                entity.Property(e => e.Text).HasColumnName("text").HasColumnType("ntext").IsRequired(false);

            });

            modelBuilder.Entity<ConnectionGroupsPermissions>(entity =>
            {
                entity.ToTable("ConnectionGroupsPermissions");

                entity.HasKey(e => e.ConnectionId);

                entity.Property(e => e.ConnectionId).HasColumnName("connectionId").ValueGeneratedNever();

                entity.Property(e => e.permissionId).HasColumnName("premissionId");

                entity.Property(e => e.groupId).HasColumnName("groupId");

                entity.HasOne(b => b.Group).WithMany(d => d.Connections).HasForeignKey(b => b.groupId).OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_ConnectionGroupsPermissions_UserPermissions");

                entity.HasOne(b => b.Permission).WithMany(d => d.Connections).HasForeignKey(b => b.permissionId).OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_ConnectionGroupsPermissions_UserGroups");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
