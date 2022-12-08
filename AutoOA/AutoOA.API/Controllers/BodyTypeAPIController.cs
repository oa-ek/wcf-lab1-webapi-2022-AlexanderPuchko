using AutoOA.Core;
using AutoOA.Repository.Dto.BodyTypeDto;
using AutoOA.Repository.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AutoOA.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BodyTypeAPIController : ControllerBase
    {
        private readonly ILogger<BodyTypeAPIController> _logger;
        private readonly BodyTypeRepository Context;

        public BodyTypeAPIController(ILogger<BodyTypeAPIController> logger, BodyTypeRepository context)
        {
            _logger = logger;
            Context = context;
        }

        [HttpGet("All-Data")]
        public async Task<IEnumerable<BodyTypeReadDto>> GetListBodyType()
        {
            return await Context.GetListAsync();
        }

        [HttpGet("One-Data{id}")]
        public async Task<BodyTypeReadDto> GetBodyTypeId(int id)
        {
            return await Context.GetAsync(id);
        }

        [HttpPost("Create-Data")]
        public async Task<int> CreateBodyType(BodyTypeCreateDto bodyType)
        {
            return await Context.CreateAsync(bodyType);
        }

    }
}
