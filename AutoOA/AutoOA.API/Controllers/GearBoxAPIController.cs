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

        [HttpGet]
        public GearBoxRepository GetGearBoxRepository()
        {
            return Context;
        }

        [HttpGet("GetHui")]
        public async Task<IEnumerable<GearBoxReadDto>> GetListAsync()
        {
            return await Context.GetListAsync();
        }
        

    }
}
