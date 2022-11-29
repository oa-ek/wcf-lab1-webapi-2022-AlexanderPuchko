using AutoMapper;
using AutoOA.Core;
using AutoOA.Repository.Dto.BodyTypeDto;
using AutoOA.Repository.Dto.DriveTypeDto;
using AutoOA.Repository.Dto.FuelTypeDto;
using AutoOA.Repository.Dto.GearBoxDto;
using AutoOA.Repository.Dto.RegionDto;
using AutoOA.Repository.Dto.SalesDataDto;
using AutoOA.Repository.Dto.UserDto;
using AutoOA.Repository.Dto.VehicleBrandDto;
using AutoOA.Repository.Dto.VehicleDto;
using AutoOA.Repository.Dto.VehicleModelDto;

namespace AutoOA.Infrastructure
{
    public class AppAutoMapper : Profile
    {
        public AppAutoMapper()
        {
            CreateMap<BodyTypeCreateDto, BodyType>();
            CreateMap<BodyType, BodyTypeReadDto>();

            CreateMap<DriveTypeCreateDto, Core.DriveType>();
            CreateMap<Core.DriveType, DriveTypeReadDto>();

            CreateMap<FuelTypeCreateDto, FuelType>();
            CreateMap<FuelType, FuelTypeReadDto>();

            CreateMap<GearBoxCreateDto, GearBox>();
            CreateMap<GearBox, GearBoxReadDto>();

            CreateMap<RegionCreateDto, Region>();
            CreateMap<Region, RegionReadDto>();

            CreateMap<SalesDataCreateDto, SalesData>();
            CreateMap<SalesData, SalesDataReadDto>();

            CreateMap<UserCreateDto, User>();
            CreateMap<User, UserReadDto>();

            CreateMap<VehicleBrand, VehicleBrandReadDto>();

            CreateMap<VehicleCreateDto, Vehicle>();
            CreateMap<Vehicle, VehicleReadDto>();

            CreateMap<VehicleModel, VehicleModelReadDto>();
        }
    }
}