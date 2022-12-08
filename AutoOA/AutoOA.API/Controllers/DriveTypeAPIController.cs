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

        public DriveTypeAPIController(ILogger<DriveTypeAPIController> logger, DriveTypeRepository context)
        {
            _logger = logger;
            Context = context;
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
    }
}
