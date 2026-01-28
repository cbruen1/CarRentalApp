using AutoMapper;
using CarRentalApi.Models;
using CarRentalApi.ModelsDTO;

namespace CarRentalApi.Api.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Vehicle, VehicleDto>().ReverseMap();
            CreateMap<VehicleCreateDto, Vehicle>();
            CreateMap<VehicleUpdateDto, Vehicle>();
        }
    }
}
