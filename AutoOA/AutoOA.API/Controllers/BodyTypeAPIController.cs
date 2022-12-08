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
        private readonly AutoOADbContext _ctx;

        public BodyTypeAPIController(ILogger<BodyTypeAPIController> logger, BodyTypeRepository context, AutoOADbContext ctx)
        {
            _logger = logger;
            Context = context;
            _ctx = ctx;
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

        [HttpPut("Update-Data{id}")]
        public async Task PutBodyType(int id, [FromBody] BodyTypeCreateDto bodyType)
        {
            await Context.Update(id, bodyType);
        }

        [HttpDelete("Delete-Data{id}")]
        public async Task<IActionResult> DeleteBodyType(int id)
        {
            var item = await _ctx.BodyTypes.FindAsync(id);

            if (item is null)
            {
                return NotFound();
            }
            await Context.DeleteBodyTypeAsync(id);

            return NoContent();
        }
    }
}
