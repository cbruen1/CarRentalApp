using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using CarRentalApi.Data.Repositories;
using CarRentalApi.Models;
using CarRentalApi.ModelsDTO;
using CarRentalApi.Services.Implementations;
using Moq;
using Xunit;

namespace CarRentalApi.UnitTests.ServiceTests
{
    public class VehicleServiceTests
    {
        private readonly Mock<IVehicleRepository> _repoMock;
        private readonly Mock<IMapper> _mapperMock;
        private readonly VehicleService _service;

        public VehicleServiceTests()
        {
            _repoMock = new Mock<IVehicleRepository>();
            _mapperMock = new Mock<IMapper>();
            _service = new VehicleService(_repoMock.Object, _mapperMock.Object);
        }

        [Fact]
        public async Task GetAllAsync_ReturnsMappedDtos()
        {
            var vehicles = new List<Vehicle>
            {
                new Vehicle
                {
                    VehicleId = 2,
                    VehicleMake = "Honda",
                    VehicleModel = "Civic",
                    VehicleReg = "24SO100",
                    VehicleType = new VehicleType() { VehicleTypeId = 1, VehicleTypeName = "Sedan" }
                }
            };

            var dtos = new List<VehicleDto>
            {
                new VehicleDto { VehicleId = 1, VehicleMake = "Toyota" }
            };

            _repoMock.Setup(r => r.GetAllAsync()).ReturnsAsync(vehicles);
            _mapperMock.Setup(m => m.Map<IEnumerable<VehicleDto>>(vehicles)).Returns(dtos);

            var result = await _service.GetAllAsync();

            Assert.Same(dtos, result);
            _repoMock.Verify(r => r.GetAllAsync(), Times.Once);
            _mapperMock.Verify(m => m.Map<IEnumerable<VehicleDto>>(vehicles), Times.Once);
        }

        [Fact]
        public async Task GetByIdAsync_ReturnsNull_WhenNotFound()
        {
            _repoMock.Setup(r => r.GetByIdAsync(It.IsAny<int>()))
                .ReturnsAsync((Vehicle)null);

            var result = await _service.GetByIdAsync(5);

            Assert.Null(result);
            _repoMock.Verify(r => r.GetByIdAsync(5), Times.Once);
            _mapperMock.Verify(m => m.Map<VehicleDto>(It.IsAny<Vehicle>()), Times.Never);
        }

        [Fact]
        public async Task GetByIdAsync_ReturnsDto_WhenFound()
        {
            var vehicle = new Vehicle
            {
                VehicleId = 2,
                VehicleMake = "Honda",
                VehicleModel = "Civic",
                VehicleReg = "24SO100",
                VehicleType = new VehicleType() { VehicleTypeId = 1, VehicleTypeName = "Sedan" }
            };
            var dto = new VehicleDto { VehicleId = 2, VehicleMake = "Honda" };

            _repoMock.Setup(r => r.GetByIdAsync(2)).ReturnsAsync(vehicle);
            _mapperMock.Setup(m => m.Map<VehicleDto>(vehicle)).Returns(dto);

            var result = await _service.GetByIdAsync(2);

            Assert.Same(dto, result);
            _repoMock.Verify(r => r.GetByIdAsync(2), Times.Once);
            _mapperMock.Verify(m => m.Map<VehicleDto>(vehicle), Times.Once);
        }

        [Fact]
        public async Task CreateAsync_MapsCreateDto_AddsAndReturnsMappedDto()
        {
            var createDto = new VehicleCreateDto { VehicleMake = "Ford" };
            var vehicleToAdd = new Vehicle
            {
                VehicleId = 2,
                VehicleMake = "Honda",
                VehicleModel = "Civic",
                VehicleReg = "24SO100",
                VehicleType = new VehicleType() { VehicleTypeId = 1, VehicleTypeName = "Sedan" }
            };
            var createdVehicle = new Vehicle
            {
                VehicleId = 10,
                VehicleMake = "Honda",
                VehicleModel = "Civic",
                VehicleReg = "24SO100",
                VehicleType = new VehicleType() { VehicleTypeId = 1, VehicleTypeName = "Sedan" }
            };
            var createdDto = new VehicleDto { VehicleId = 10, VehicleMake = "Ford" };

            _mapperMock.Setup(m => m.Map<Vehicle>(createDto)).Returns(vehicleToAdd);
            _repoMock.Setup(r => r.AddAsync(vehicleToAdd)).ReturnsAsync(createdVehicle);
            _mapperMock.Setup(m => m.Map<VehicleDto>(createdVehicle)).Returns(createdDto);

            var result = await _service.CreateAsync(createDto);

            Assert.Same(createdDto, result);
            _mapperMock.Verify(m => m.Map<Vehicle>(createDto), Times.Once);
            _repoMock.Verify(r => r.AddAsync(vehicleToAdd), Times.Once);
            _mapperMock.Verify(m => m.Map<VehicleDto>(createdVehicle), Times.Once);
        }

        [Fact]
        public async Task UpdateAsync_ReturnsFalse_WhenNotExists()
        {
            var updateDto = new VehicleUpdateDto { VehicleMake = "Mazda" };

            _repoMock.Setup(r => r.ExistsAsync(99)).ReturnsAsync(false);

            var result = await _service.UpdateAsync(99, updateDto);

            Assert.False(result);
            _repoMock.Verify(r => r.ExistsAsync(99), Times.Once);
            _mapperMock.Verify(m => m.Map<Vehicle>(It.IsAny<VehicleUpdateDto>()), Times.Never);
            _repoMock.Verify(r => r.UpdateAsync(It.IsAny<Vehicle>()), Times.Never);
        }

        [Fact]
        public async Task UpdateAsync_ReturnsTrue_WhenExists_AndSetsVehicleId()
        {
            var id = 7;
            var updateDto = new VehicleUpdateDto { VehicleMake = "Subaru" };
            var mappedVehicle = new Vehicle
            {
                //VehicleId = 10,
                VehicleMake = "Honda",
                VehicleModel = "Civic",
                VehicleReg = "24SO100",
                VehicleType = new VehicleType() { VehicleTypeId = 1, VehicleTypeName = "Sedan" }
            }; // no id set yet

            _repoMock.Setup(r => r.ExistsAsync(id)).ReturnsAsync(true);
            _mapperMock.Setup(m => m.Map<Vehicle>(updateDto)).Returns(mappedVehicle);
            _repoMock.Setup(r => r.UpdateAsync(It.IsAny<Vehicle>())).Returns(Task.CompletedTask);

            var result = await _service.UpdateAsync(id, updateDto);

            Assert.True(result);
            _repoMock.Verify(r => r.ExistsAsync(id), Times.Once);
            _mapperMock.Verify(m => m.Map<Vehicle>(updateDto), Times.Once);
            _repoMock.Verify(r => r.UpdateAsync(It.Is<Vehicle>(v => v == mappedVehicle && v.VehicleId == id)), Times.Once);
        }

        [Fact]
        public async Task DeleteAsync_ReturnsFalse_WhenNotExists()
        {
            _repoMock.Setup(r => r.ExistsAsync(123)).ReturnsAsync(false);

            var result = await _service.DeleteAsync(123);

            Assert.False(result);
            _repoMock.Verify(r => r.ExistsAsync(123), Times.Once);
            _repoMock.Verify(r => r.DeleteAsync(It.IsAny<int>()), Times.Never);
        }

        [Fact]
        public async Task DeleteAsync_ReturnsTrue_WhenExists_AndCallsDelete()
        {
            var id = 55;
            _repoMock.Setup(r => r.ExistsAsync(id)).ReturnsAsync(true);
            _repoMock.Setup(r => r.DeleteAsync(id)).Returns(Task.CompletedTask);

            var result = await _service.DeleteAsync(id);

            Assert.True(result);
            _repoMock.Verify(r => r.ExistsAsync(id), Times.Once);
            _repoMock.Verify(r => r.DeleteAsync(id), Times.Once);
        }
    }

}
