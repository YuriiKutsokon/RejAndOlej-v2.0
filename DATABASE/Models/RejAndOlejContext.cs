using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace RejAndOlej.Models
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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=PL01-PC04\\SQLEXPRESS01;Database=RejAndOlej;Trusted_Connection=True;");
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

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
