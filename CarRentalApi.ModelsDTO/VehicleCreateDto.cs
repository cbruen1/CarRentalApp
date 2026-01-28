using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalApi.ModelsDTO
{
    // DTOs/VehicleCreateDto.cs
    public class VehicleCreateDto
    {
        public int VehicleTypeId { get; set; }

        public string VehicleMake { get; set; }
        public string VehicleModel { get; set; }
        public string VehicleReg { get; set; }
        public int VehicleYear { get; set; }
        public string VehicleColour { get; set; }
    }
}
