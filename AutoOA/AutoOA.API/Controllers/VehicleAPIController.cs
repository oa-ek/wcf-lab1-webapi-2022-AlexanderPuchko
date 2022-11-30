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

        public VehicleAPIController(ILogger<VehicleAPIController> logger, VehicleRepository context)
        {
            _logger = logger;
            Context = context;
        }

        [HttpGet]
        public VehicleRepository GetVehicleRepository()
        {
            return Context;
        }

        [HttpGet("GetHui")]
        public async Task<IEnumerable<VehicleReadDto>> GetListAsync()
        {
            return await Context.GetListAsync();
        }
        

    }
}
