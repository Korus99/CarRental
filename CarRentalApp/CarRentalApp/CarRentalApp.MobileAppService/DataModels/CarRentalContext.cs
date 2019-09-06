using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CarRentalApp.MobileAppService.DataModels
{
    public partial class CarRentalContext : DbContext
    {
        public CarRentalContext()
        {
        }

        public CarRentalContext(DbContextOptions<CarRentalContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AvailabilityData> Availability { get; set; }
        public virtual DbSet<MaintenanceData> Maintenance { get; set; }
        public virtual DbSet<MaintenanceScheduleData> MaintenanceSchedule { get; set; }
        public virtual DbSet<UserData> User { get; set; }
        public virtual DbSet<UserType> UserType { get; set; }
        public virtual DbSet<VehicleData> Vehicle { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=CarRental;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<AvailabilityData>(entity =>
            {
                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.ReturnedDate).HasColumnType("datetime");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.VehicleId).HasColumnName("VehicleID");

                entity.HasOne(d => d.Maintenance)
                    .WithMany(p => p.Availability)
                    .HasForeignKey(d => d.MaintenanceId)
                    .HasConstraintName("FK_Availability_ToTable");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Availability)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_Availability_ToUser");

                entity.HasOne(d => d.Vehicle)
                    .WithMany(p => p.Availability)
                    .HasForeignKey(d => d.VehicleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Availability_ToVehicle");
            });

            modelBuilder.Entity<MaintenanceData>(entity =>
            {
                entity.Property(e => e.MaintEnd).HasMaxLength(10);

                entity.Property(e => e.MaintStart).HasColumnType("datetime");

                entity.HasOne(d => d.CompletedByNavigation)
                    .WithMany(p => p.Maintenance)
                    .HasForeignKey(d => d.CompletedBy)
                    .HasConstraintName("FK_Maintenance_ToUser");

                entity.HasOne(d => d.MaintenanceNavigation)
                    .WithMany(p => p.MaintenanceNavigation)
                    .HasForeignKey(d => d.MaintenanceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Maintenance_ToMainSchedule");

                entity.HasOne(d => d.Vehicle)
                    .WithMany(p => p.Maintenance)
                    .HasForeignKey(d => d.VehicleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Maintenance_ToVehicle");
            });

            modelBuilder.Entity<MaintenanceScheduleData>(entity =>
            {
                entity.Property(e => e.DueDate).HasColumnType("date");

                entity.Property(e => e.Maintenance)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.HasOne(d => d.Vehicle)
                    .WithMany(p => p.MaintenanceSchedule)
                    .HasForeignKey(d => d.VehicleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MaintenanceSchedule_ToVehicle");
            });

            modelBuilder.Entity<UserData>(entity =>
            {
                entity.Property(e => e.Brand).HasMaxLength(50);

                entity.Property(e => e.License).HasMaxLength(50);

                entity.Property(e => e.Make).HasMaxLength(50);

                entity.Property(e => e.Name)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.State).HasMaxLength(50);

                entity.HasOne(d => d.UserTypeNavigation)
                    .WithMany(p => p.User)
                    .HasForeignKey(d => d.UserType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_User_ToUserType");
            });

            modelBuilder.Entity<UserType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VehicleData>(entity =>
            {
                entity.Property(e => e.Brand)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.License)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Location)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Make)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.State).HasMaxLength(2);

                entity.Property(e => e.Vin)
                    .IsRequired()
                    .HasColumnName("VIN")
                    .HasMaxLength(17)
                    .IsUnicode(false);
            });
        }
    }
}
