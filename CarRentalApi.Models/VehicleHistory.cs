using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalApi.Models
{
    public class VehicleHistory
    {
        public int VehicleHistoryId { get; set; }
        public int VehicleId { get; set; }
        public DateTime VehicleHistoryDate { get; set; }
        public string Notes { get; set; }

        public Vehicle Vehicle { get; set; }
    }
}
