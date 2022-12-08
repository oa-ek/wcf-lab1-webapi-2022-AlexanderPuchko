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
        private readonly AutoOADbContext _ctx;

        public FuelTypeAPIController(ILogger<FuelTypeAPIController> logger, FuelTypeRepository context, AutoOADbContext ctx)
        {
            _logger = logger;
            Context = context;
            _ctx = ctx;
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

        [HttpPut("Update-Data{id}")]
        public async Task PutFuelType(int id, [FromBody] FuelTypeCreateDto fuelType)
        {
            await Context.Update(id, fuelType);
        }

        [HttpDelete("Delete-Data{id}")]
        public async Task<IActionResult> DeleteFuelType(int id)
        {
            var item = await _ctx.FuelTypes.FindAsync(id);

            if (item is null)
            {
                return NotFound();
            }
            await Context.DeleteFuelTypeAsync(id);

            return NoContent();
        }
    }
}
