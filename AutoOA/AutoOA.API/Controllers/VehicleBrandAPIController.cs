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
        private readonly AutoOADbContext _ctx;

        public VehicleBrandAPIController(ILogger<VehicleBrandAPIController> logger, VehicleBrandRepository context, AutoOADbContext ctx)
        {
            _logger = logger;
            Context = context;
            _ctx = ctx;
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

        [HttpPost("Create-Data")]
        public async Task<int> CreateVehicleBrand(VehicleBrandCreateDto brandDto)
        {
            return await Context.CreateAsync(brandDto);
        }

        [HttpPut("Update-Data{id}")]
        public async Task PutVehicleBrand(int id, [FromBody] VehicleBrandCreateDto brandDto)
        {
            await Context.Update(id, brandDto);
        }

        [HttpDelete("Delete-Data{id}")]
        public async Task<IActionResult> DeleteVehicleBrand(int id)
        {
            var item = await _ctx.VehicleBrands.FindAsync(id);

            if (item is null)
            {
                return NotFound();
            }
            await Context.DeleteVehicleBrandAsync(id);

            return NoContent();
        }

    }
}
