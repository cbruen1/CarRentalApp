using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalApi.Models
{
    public class CustomerAddress
    {
        public int CustomerAddressId { get; set; }
        public string CustomerAddress1 { get; set; }
        public string CustomerAddress2 { get; set; }
        public string CustomerAddressCity { get; set; }
        public string CustomerAddressCounty { get; set; }
        public string CustomerAddressCountry { get; set; }
        public string CustomerAddressPostCode { get; set; }

        public ICollection<Customer> Customers { get; set; }
    }
}
