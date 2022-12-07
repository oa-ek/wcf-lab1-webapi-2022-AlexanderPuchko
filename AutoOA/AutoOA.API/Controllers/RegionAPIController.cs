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

        public RegionAPIController(ILogger<RegionAPIController> logger, RegionRepository context)
        {
            _logger = logger;
            Context = context;
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

    }
}
