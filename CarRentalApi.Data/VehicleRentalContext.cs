using CarRentalApi.Data.Configurations;
using CarRentalApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalApi.Data
{
    public class VehicleRentalContext : DbContext
    {
        public VehicleRentalContext(DbContextOptions<VehicleRentalContext> options)
            : base(options)
        {
        }

        public DbSet<VehicleType> VehicleTypes { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<VehicleLocation> VehicleLocations { get; set; }
        public DbSet<VehicleDamageType> VehicleDamageTypes { get; set; }
        public DbSet<VehicleDamage> VehicleDamages { get; set; }
        public DbSet<VehicleBooking> VehicleBookings { get; set; }
        public DbSet<Customer> Customers { get; set; }
        
        // ... other DbSets

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // modelBuilder.ApplyConfiguration(new VehicleConfiguration());

            modelBuilder.Entity<VehicleType>()
                .HasMany(vt => vt.Vehicles)
                .WithOne(v => v.VehicleType)
                .HasForeignKey(v => v.VehicleTypeId)
                .IsRequired();   // Vehicle must have a type

            modelBuilder.Entity<VehicleType>()
                .Property(vt => vt.VehicleTypeName)
                .IsRequired()
                .HasMaxLength(50);

            modelBuilder.Entity<VehicleType>().HasData(
                new VehicleType { VehicleTypeId = 1, VehicleTypeName = "Sedan" },
                new VehicleType { VehicleTypeId = 2, VehicleTypeName = "SUV" },
                new VehicleType { VehicleTypeId = 3, VehicleTypeName = "Van" }
            );

            // Composite key for VehicleDamage (no explicit ID provided)
            modelBuilder.Entity<VehicleDamage>()
                .HasKey(vd => new { vd.VehicleId, vd.VehicleDamageTypeId, vd.CustomerId, vd.VehicleBookingId });

            // modelBuilder.ApplyConfiguration(new VehicleTypeConfiguration());
            // modelBuilder.ApplyConfiguration(new VehicleLocationConfiguration());
            // etc.

            // Example composite key for VehicleDamage if you keep it keyless:
            // modelBuilder.Entity<VehicleDamage>()
            //     .HasKey(vd => new { vd.VehicleId, vd.VehicleDamageTypeId, vd.CustomerId, vd.VehicleBookingId });
        }
    }

}
