using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalApi.Models
{
    public class VehicleBooking
    {
        public int VehicleBookingId { get; set; }
        public int VehicleId { get; set; }
        public int CustomerId { get; set; }
        public DateTime BookingStartDate { get; set; }
        public DateTime BookingEndDate { get; set; }

        public Vehicle Vehicle { get; set; }
        public Customer Customer { get; set; }
        //public ICollection<VehicleDamage> VehicleDamages { get; set; }
    }
}
