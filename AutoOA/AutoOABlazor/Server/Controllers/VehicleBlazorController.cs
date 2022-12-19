using Microsoft.AspNetCore.Mvc;
using AutoOA.Repository.Repositories;
using AutoOA.Repository.Dto.VehicleDto;

namespace AutoOABlazor.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleBlazorController : ControllerBase
    {
        private readonly BodyTypeRepository bodyTypeR;
        private readonly DriveTypeRepository driveTypeR;
        private readonly FuelTypeRepository fuelTypeR;
        private readonly GearBoxRepository gearBoxR;
        private readonly RegionRepository regionR;
        private readonly SalesDataRepository salesDataR;
        //private readonly UsersRepository usersR;
        private readonly VehicleBrandRepository vehicleBrandR;
        private readonly VehicleModelRepository vehicleModelR;
        private readonly VehicleRepository vehicleR;
        private readonly ILogger<VehicleBlazorController> logger;

        public VehicleBlazorController(ILogger<VehicleBlazorController> _logger, VehicleRepository _vehicle, VehicleModelRepository _vehicleModel, VehicleBrandRepository _vehicleBrand, 
            SalesDataRepository _salesData, RegionRepository _region, GearBoxRepository _gearBox, FuelTypeRepository _fuelType, DriveTypeRepository _driveType, BodyTypeRepository _bodyType)
        {
            
            vehicleR= _vehicle;
            logger= _logger;
            vehicleModelR= _vehicleModel;
            vehicleBrandR= _vehicleBrand;
            salesDataR= _salesData;
            regionR= _region;
            gearBoxR= _gearBox;
            fuelTypeR= _fuelType;
            driveTypeR= _driveType;
            bodyTypeR= _bodyType;
        }


        [HttpGet("/vehicle")]
        public async Task<IActionResult> GetListAsync()
        {
            return Ok(await vehicleR.GetListAsync());
        }
        /*
        [HttpGet("{id}")]
        public async Task<VehicleReadDto> GetId(int id)
        {
            return await VehicleRepository.GetAsync(id);
        }
        [HttpGet("{id}")]
        public async Task Delete(int id)
        {
            await VehicleRepository.DeleteTimetableAsync(id);
        }
        */


    }
}
