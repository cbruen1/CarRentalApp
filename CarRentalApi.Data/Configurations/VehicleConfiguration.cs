using CarRentalApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalApi.Data.Configurations
{
    public class VehicleConfiguration : IEntityTypeConfiguration<Vehicle>
    {
        public void Configure(EntityTypeBuilder<Vehicle> builder)
        {
            builder.HasKey(v => v.VehicleId);

            builder.Property(v => v.VehicleModel)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(v => v.VehicleReg)
                .IsRequired()
                .HasMaxLength(20);

            builder.Property(v => v.VehicleColour)
                .HasMaxLength(50);

            builder.HasOne(v => v.VehicleType)
                .WithMany(t => t.Vehicles)
                .HasForeignKey(v => v.VehicleTypeId);
        }
    }

}
