using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalApi.Models
{
    public class VehiclePrice
    {
        public int VehiclePriceId { get; set; }
        public int VehicleTypeId { get; set; }
        public DateTime VehiclePriceDateFrom { get; set; }
        public DateTime VehiclePriceDateTo { get; set; }
        public decimal VehicleDailyPrice { get; set; }

        public VehicleType VehicleType { get; set; }
    }
}
