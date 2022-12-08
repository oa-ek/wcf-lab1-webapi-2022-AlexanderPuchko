using AutoOA.Core;
using AutoOA.Repository.Dto.GearBoxDto;
using AutoOA.Repository.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AutoOA.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GearBoxAPIController : ControllerBase
    {
        private readonly ILogger<GearBoxAPIController> _logger;
        private readonly GearBoxRepository Context;
        private readonly AutoOADbContext _ctx;

        public GearBoxAPIController(ILogger<GearBoxAPIController> logger, GearBoxRepository context, AutoOADbContext ctx)
        {
            _logger = logger;
            Context = context;
            _ctx = ctx;
        }


        [HttpGet("All-Data")]
        public async Task<IEnumerable<GearBoxReadDto>> GetListGearBox()
        {
            return await Context.GetListAsync();
        }

        [HttpGet("One-Data{id}")]
        public async Task<GearBoxReadDto> GetGearBoxId(int id)
        {
            return await Context.GetAsync(id);
        }

        [HttpPost("Create-Data")]
        public async Task<int> CreateGearBox(GearBoxCreateDto gearType)
        {
            return await Context.CreateAsync(gearType);
        }

        [HttpPut("Update-Data{id}")]
        public async Task PutGearBox(int id, [FromBody] GearBoxCreateDto gearType)
        {
            await Context.Update(id, gearType);
        }

        [HttpDelete("Delete-Data{id}")]
        public async Task<IActionResult> DeleteGearBox(int id)
        {
            var item = await _ctx.GearBoxes.FindAsync(id);

            if (item is null)
            {
                return NotFound();
            }
            await Context.DeleteGearBoxAsync(id);

            return NoContent();
        }
    }
}
