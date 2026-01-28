using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalApi.Models
{
    public class VehicleDamage
    {
        public int VehicleId { get; set; }
        public int VehicleDamageTypeId { get; set; }
        public int CustomerId { get; set; }
        public DateTime VehicleDamageDate { get; set; }
        public int VehicleBookingId { get; set; }

        public Vehicle Vehicle { get; set; }
        public VehicleDamageType VehicleDamageType { get; set; }
        public Customer Customer { get; set; }
        //public VehicleBooking VehicleBooking { get; set; }
    }
}
