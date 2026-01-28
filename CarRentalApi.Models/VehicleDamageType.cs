using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalApi.Models
{
    public class VehicleDamageType
    {
        public int VehicleDamageTypeId { get; set; }
        public string VehicleDamageTypeName { get; set; }

        public ICollection<VehicleDamage> VehicleDamages { get; set; }
    }
}
