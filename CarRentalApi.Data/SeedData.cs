using CarRentalApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalApi.Data
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new VehicleRentalContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<VehicleRentalContext>>()))
            {
                if (context == null || context.Vehicles == null)
                {
                    throw new ArgumentNullException("Null CarRentalContext");
                }

                // Look for any Vehicles.
                if (context.Vehicles.Any())
                {
                    return;   // DB has been seeded
                }

                // Seed VehicleTypes if not present
                context.VehicleTypes.AddRange(
                    new VehicleType { VehicleTypeName = "Sedan" },
                    new VehicleType { VehicleTypeName = "SUV" },
                    new VehicleType { VehicleTypeName = "Van" }
                );

                // Seed VehicleLocations if not present
                context.VehicleLocations.AddRange(
                    new VehicleLocation 
                    { 
                        VehicleLocationAddress1 = "100 Upper Lower Street", 
                        VehicleLocationCity = "Dublin",
                        VehicleLocationCounty = "Dublin",
                        VehicleLocationCountry = "Ireland",
                        VehicleLocationPostcode = "D01 ABC2"
                    },
                    new VehicleLocation 
                    { 
                        VehicleLocationAddress1 = "42 Streedagh Terrace", 
                        VehicleLocationCity = "Sligo",
                        VehicleLocationCounty = "Sligo",
                        VehicleLocationCountry = "Ireland",
                        VehicleLocationPostcode = "F91 ABC2"
                    }
                );

                // Seed initial Vehicle data
                context.Vehicles.AddRange(
                    new Vehicle
                    {
                        VehicleMake = "Maserati",
                        VehicleModel = "Levante",
                        VehicleReg = "20SO1",
                        VehicleYear = 2020,
                        VehicleColour = "Blue",
                        VehicleCostPrice = 80000M,
                        VehicleType = context.VehicleTypes.FirstOrDefault(vt => vt.VehicleTypeName == "Sedan"),
                        VehicleLocation = context.VehicleLocations.FirstOrDefault(vl => vl.VehicleLocationPostcode == "D01 ABC2")
                    },
                    new Vehicle
                    {
                        VehicleMake = "BMW",
                        VehicleModel = "316",
                        VehicleReg = "21SO1",
                        VehicleYear = 2021,
                        VehicleColour = "Red",
                        VehicleCostPrice = 40000M,
                        VehicleType = context.VehicleTypes.FirstOrDefault(vt => vt.VehicleTypeName == "Sedan"),
                        VehicleLocation = context.VehicleLocations.FirstOrDefault(vl => vl.VehicleLocationPostcode == "F91 ABC2")
                    },
                    new Vehicle
                    {
                        VehicleMake = "Toyota",
                        VehicleModel = "Corolla",
                        VehicleReg = "22SO1",
                        VehicleYear = 2022,
                        VehicleColour = "White",
                        VehicleCostPrice = 25000M,
                        VehicleType = context.VehicleTypes.FirstOrDefault(vt => vt.VehicleTypeName == "Van"),
                        VehicleLocation = context.VehicleLocations.FirstOrDefault(vl => vl.VehicleLocationPostcode == "D01 ABC2")
                    },
                    new Vehicle
                    {
                        VehicleMake = "Toyota",
                        VehicleModel = "Hilux",
                        VehicleReg = "23SO1",
                        VehicleYear = 2023,
                        VehicleColour = "Green",
                        VehicleCostPrice = 28000M,
                        VehicleType = context.VehicleTypes.FirstOrDefault(vt => vt.VehicleTypeName == "SUV"),
                        VehicleLocation = context.VehicleLocations.FirstOrDefault(vl => vl.VehicleLocationPostcode == "D01 ABC2")
                    }
                );

                //context.SaveChanges();
            }
        }
    }

}
