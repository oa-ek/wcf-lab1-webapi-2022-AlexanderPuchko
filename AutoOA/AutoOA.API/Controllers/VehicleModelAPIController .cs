using AutoOA.Core;
using AutoOA.Repository.Dto.VehicleModelDto;
using AutoOA.Repository.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AutoOA.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleModelAPIController : ControllerBase
    {
        private readonly ILogger<VehicleModelAPIController> _logger;
        private readonly VehicleModelRepository Context;

        public VehicleModelAPIController(ILogger<VehicleModelAPIController> logger, VehicleModelRepository context)
        {
            _logger = logger;
            Context = context;
        }

        [HttpGet("All-Data")]
        public async Task<IEnumerable<VehicleModelReadDto>> GetListVehicleModel()
        {
            return await Context.GetListAsync();
        }

        [HttpGet("One-Data{id}")]
        public async Task<VehicleModelReadDto> GetVehicleModelId(int id)
        {
            return await Context.GetAsync(id);
        }

    }
}
