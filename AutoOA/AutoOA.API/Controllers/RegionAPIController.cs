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

        [HttpGet]
        public RegionRepository GetRegionRepository()
        {
            return Context;
        }

        [HttpGet("GetHui")]
        public async Task<IEnumerable<RegionReadDto>> GetListAsync()
        {
            return await Context.GetListAsync();
        }
        

    }
}
