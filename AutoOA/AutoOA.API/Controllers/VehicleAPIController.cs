using AutoOA.Core;
using AutoOA.Repository.Dto.VehicleDto;
using AutoOA.Repository.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AutoOA.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleAPIController : ControllerBase
    {
        private readonly ILogger<VehicleAPIController> _logger;
        private readonly VehicleRepository Context;
        private readonly AutoOADbContext _ctx;

        public VehicleAPIController(ILogger<VehicleAPIController> logger, VehicleRepository context, AutoOADbContext ctx)
        {
            _logger = logger;
            Context = context;
            _ctx = ctx;
        }

        [HttpGet("All-Data")]
        public async Task<IEnumerable<VehicleReadDto>> GetListVehicle()
        {
            return await Context.GetListAsync();
        }

        [HttpGet("One-Data{id}")]
        public async Task<VehicleReadDto> GetVehicleId(int id)
        {
            return await Context.GetAsync(id);
        }

        [HttpPost("Create-Data")]
        public async Task<Vehicle> CreateVehicle(Vehicle vehicleDto)
        {
            return await Context.AddVehicleAsync(vehicleDto);
        }

        [HttpPut("{id}")]
        public async Task PutVehicle(int id, [FromBody] VehicleReadDto vehicleDto, string regionName, string bodyTypeName,
            string vehicleBrandName, string vehicleModelName, string gearBoxName, string driveTypeName, string fuelTypeName)
        {
            await Context.UpdateAsync(id, vehicleDto, regionName, bodyTypeName,
             vehicleBrandName, vehicleModelName, gearBoxName, driveTypeName, fuelTypeName);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVehicle(int id)
        {
            var item = await _ctx.Vehicles.FindAsync(id);

            if (item is null)
            {
                return NotFound();
            }
            await Context.DeleteVehicleAsync(id);

            return NoContent();
        }
    }
}
