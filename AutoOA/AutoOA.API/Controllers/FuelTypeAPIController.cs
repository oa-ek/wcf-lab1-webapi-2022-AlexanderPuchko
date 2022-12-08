using AutoOA.Core;
using AutoOA.Repository.Dto.FuelTypeDto;
using AutoOA.Repository.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AutoOA.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FuelTypeAPIController : ControllerBase
    {
        private readonly ILogger<FuelTypeAPIController> _logger;
        private readonly FuelTypeRepository Context;

        public FuelTypeAPIController(ILogger<FuelTypeAPIController> logger, FuelTypeRepository context)
        {
            _logger = logger;
            Context = context;
        }

        [HttpGet("All-Data")]
        public async Task<IEnumerable<FuelTypeReadDto>> GetListFuelType()
        {
            return await Context.GetListAsync();
        }

        [HttpGet("One-Data{id}")]
        public async Task<FuelTypeReadDto> GetFuelTypeId(int id)
        {
            return await Context.GetAsync(id);
        }

        [HttpPost("Create-Data")]
        public async Task<int> CreateFuelType(FuelTypeCreateDto fuelType)
        {
            return await Context.CreateAsync(fuelType);
        }
    }
}
