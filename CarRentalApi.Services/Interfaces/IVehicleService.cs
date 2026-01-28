using CarRentalApi.ModelsDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalApi.Services.Interfaces
{
    public interface IVehicleService
    {
        Task<IEnumerable<VehicleDto>> GetAllAsync();
        Task<VehicleDto> GetByIdAsync(int id);
        Task<VehicleDto> CreateAsync(VehicleCreateDto dto);
        Task<bool> UpdateAsync(int id, VehicleUpdateDto dto);
        Task<bool> DeleteAsync(int id);
    }

}
