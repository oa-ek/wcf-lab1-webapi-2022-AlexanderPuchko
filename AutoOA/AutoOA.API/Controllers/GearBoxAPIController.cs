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

        public GearBoxAPIController(ILogger<GearBoxAPIController> logger, GearBoxRepository context)
        {
            _logger = logger;
            Context = context;
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

    }
}
