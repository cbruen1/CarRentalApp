using AutoMapper;
using CarRentalApi.Data.Repositories;
using CarRentalApi.Models;
using CarRentalApi.ModelsDTO;
using CarRentalApi.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalApi.Services.Implementations
{
    public class VehicleService : IVehicleService
    {
        private readonly IVehicleRepository _vehicleRepository;
        private readonly IMapper _mapper;

        public VehicleService(IVehicleRepository vehicleRepository, IMapper mapper)
        {
            _vehicleRepository = vehicleRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<VehicleDto>> GetAllAsync()
        {
            var vehicles = await _vehicleRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<VehicleDto>>(vehicles);
        }

        public async Task<VehicleDto> GetByIdAsync(int id)
        {
            var vehicle = await _vehicleRepository.GetByIdAsync(id);
            return vehicle == null ? null : _mapper.Map<VehicleDto>(vehicle);
        }

        public async Task<VehicleDto> CreateAsync(VehicleCreateDto dto)
        {
            var vehicle = _mapper.Map<Vehicle>(dto);
            var created = await _vehicleRepository.AddAsync(vehicle);
            return _mapper.Map<VehicleDto>(created);
        }

        public async Task<bool> UpdateAsync(int id, VehicleUpdateDto dto)
        {
            var exists = await _vehicleRepository.ExistsAsync(id);
            if (!exists) return false;

            var vehicle = _mapper.Map<Vehicle>(dto);
            vehicle.VehicleId = id;

            await _vehicleRepository.UpdateAsync(vehicle);
            return true;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var exists = await _vehicleRepository.ExistsAsync(id);
            if (!exists) return false;

            await _vehicleRepository.DeleteAsync(id);
            return true;
        }
    }

}
