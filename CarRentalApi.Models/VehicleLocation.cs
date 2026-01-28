using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalApi.Models
{
    public class VehicleLocation
    {
        public int VehicleLocationId { get; set; }
        public string VehicleLocationAddress1 { get; set; }
        public string? VehicleLocationAddress2 { get; set; }
        public string VehicleLocationCity { get; set; }
        public string VehicleLocationCounty { get; set; }
        public string VehicleLocationCountry { get; set; }
        public string? VehicleLocationPostcode { get; set; }

        // public ICollection<VehicleType> VehicleTypes { get; set; }
    }
}
