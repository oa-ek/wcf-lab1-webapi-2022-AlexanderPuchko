using AutoOA.Core;
using AutoOA.Repository.Dto.VehicleBrandDto;
using AutoOA.Repository.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AutoOA.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleBrandAPIController : ControllerBase
    {
        private readonly ILogger<VehicleBrandAPIController> _logger;
        private readonly VehicleBrandRepository Context;

        public VehicleBrandAPIController(ILogger<VehicleBrandAPIController> logger, VehicleBrandRepository context)
        {
            _logger = logger;
            Context = context;
        }

        [HttpGet("All-Data")]
        public async Task<IEnumerable<VehicleBrandReadDto>> GetListVehicleBrand()
        {
            return await Context.GetListAsync();
        }

        [HttpGet("One-Data{id}")]
        public async Task<VehicleBrandReadDto> GetVehicleBrandId(int id)
        {
            return await Context.GetAsync(id);
        }

    }
}
