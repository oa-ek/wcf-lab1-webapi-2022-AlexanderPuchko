using AutoOA.Core;
using AutoOA.Repository.Dto.RegionDto;
using AutoOA.Repository.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AutoOA.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegionAPIController : ControllerBase
    {
        private readonly ILogger<RegionAPIController> _logger;
        private readonly RegionRepository Context;
        private readonly AutoOADbContext _ctx;

        public RegionAPIController(ILogger<RegionAPIController> logger, RegionRepository context, AutoOADbContext ctx)
        {
            _logger = logger;
            Context = context;
            _ctx = ctx;
        }

        [HttpGet("All-Data")]
        public async Task<IEnumerable<RegionReadDto>> GetLisRegion()
        {
            return await Context.GetListAsync();
        }

        [HttpGet("One-Data{id}")]
        public async Task<RegionReadDto> GetRegionId(int id)
        {
            return await Context.GetAsync(id);
        }

        [HttpPost("Create-Data")]
        public async Task<int> CreateRegion(RegionCreateDto regionDto)
        {
            return await Context.CreateAsync(regionDto);
        }

        [HttpPut("Update-Data{id}")]
        public async Task PutRegion(int id, [FromBody] RegionCreateDto regionDto)
        {
            await Context.Update(id, regionDto);
        }

        [HttpDelete("Delete-Data{id}")]
        public async Task<IActionResult> DeleteRegion(int id)
        {
            var item = await _ctx.Regions.FindAsync(id);

            if (item is null)
            {
                return NotFound();
            }
            await Context.DeleteRegionAsync(id);

            return NoContent();
        }
    }
}
