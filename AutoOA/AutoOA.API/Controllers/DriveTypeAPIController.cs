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

        [HttpGet]
        public DriveTypeRepository GetDriveTypeRepository()
        {
            return Context;
        }

        [HttpGet("GetHui")]
        public async Task<IEnumerable<DriveTypeReadDto>> GetListAsync()
        {
            return await Context.GetListAsync();
        }
        

    }
}
