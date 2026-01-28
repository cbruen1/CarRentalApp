using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalApi.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerFirstName { get; set; }
        public string CustomerLastName { get; set; }
        public int CustomerAddressId { get; set; }
        public DateTime CustomerDOB { get; set; }
        public string CustomerEmail { get; set; }

        public CustomerAddress CustomerAddress { get; set; }
        public ICollection<VehicleBooking> VehicleBookings { get; set; }
        public ICollection<VehicleDamage> VehicleDamages { get; set; }
    }
}
