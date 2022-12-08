using AutoOA.Core;
using AutoOA.Repository.Dto.DriveTypeDto;
using AutoOA.Repository.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AutoOA.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DriveTypeAPIController : ControllerBase
    {
        private readonly ILogger<DriveTypeAPIController> _logger;
        private readonly DriveTypeRepository Context;
        private readonly AutoOADbContext _ctx;

        public DriveTypeAPIController(ILogger<DriveTypeAPIController> logger, DriveTypeRepository context, AutoOADbContext ctx)
        {
            _logger = logger;
            Context = context;
            _ctx = ctx;
        }
        [HttpGet("All-Data")]
        public async Task<IEnumerable<DriveTypeReadDto>> GetListDriveType()
        {
            return await Context.GetListAsync();
        }

        [HttpGet("One-Data{id}")]
        public async Task<DriveTypeReadDto> GetDriveTypeId(int id)
        {
            return await Context.GetAsync(id);
        }

        [HttpPost("Create-Data")]
        public async Task<int> CreateDriveType(DriveTypeCreateDto bodyType)
        {
            return await Context.CreateAsync(bodyType);
        }
        [HttpPut("Update-Data{id}")]
        public async Task PutDriveType(int id, [FromBody] DriveTypeCreateDto bodyType)
        {
            await Context.Update(id, bodyType);
        }
        [HttpDelete("Delete-Data{id}")]
        public async Task<IActionResult> DeleteDriveType(int id)
        {
            var item = await _ctx.DriveTypes.FindAsync(id);

            if (item is null)
            {
                return NotFound();
            }
            await Context.DeleteDriveTypeAsync(id);

            return NoContent();
        }
    }
}
