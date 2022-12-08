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
        private readonly AutoOADbContext _ctx;

        public VehicleModelAPIController(ILogger<VehicleModelAPIController> logger, VehicleModelRepository context, AutoOADbContext ctx)
        {
            _logger = logger;
            Context = context;
            _ctx = ctx;
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

        [HttpPost("Creat-Data")]
        public async Task<int> CreateVehicleModel(VehicleModelCreateDto modelDto)
        {
            return await Context.CreateAsync(modelDto);
        }

        [HttpPut("Update-Data{id}")]
        public async Task Put(int id, [FromBody] VehicleModelCreateDto modelDto)
        {
            await Context.Update(id, modelDto);
        }

        [HttpDelete("Delete-Data{id}")]
        public async Task<IActionResult> DeleteVehicleModel(int id)
        {
            var item = await _ctx.VehicleModels.FindAsync(id);

            if (item is null)
            {
                return NotFound();
            }
            await Context.DeleteVehicleModelAsync(id);

            return NoContent();
        }
    }
}
