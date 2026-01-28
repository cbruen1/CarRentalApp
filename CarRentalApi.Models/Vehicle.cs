using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalApi.Models
{
    public class Vehicle
    {
        public int VehicleId { get; set; }
        public int VehicleTypeId { get; set; }

        [Display(Name = "Vehicle Make")]
        public required string VehicleMake { get; set; }

        [Display(Name = "Vehicle Model")]
        public required string VehicleModel { get; set; }

        [Display(Name = "Vehicle Reg")]
        public required string VehicleReg { get; set; }

        public int VehicleYear { get; set; }

        public string? VehicleColour { get; set; }

        [Column(TypeName = "decimal(10, 2)")]
        public decimal VehicleCostPrice { get; set; }
        public int VehicleLocationId { get; set; }

        public VehicleLocation? VehicleLocation { get; set; }

        public required VehicleType VehicleType { get; set; }
        //public ICollection<VehicleBooking> VehicleBookings { get; set; }
        //public ICollection<VehicleDamage> VehicleDamages { get; set; }
        //public ICollection<VehicleHistory> VehicleHistories { get; set; }
    }
}
