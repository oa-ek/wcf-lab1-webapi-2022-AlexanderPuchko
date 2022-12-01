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

        [HttpGet]
        public BodyTypeRepository GetBodyTypeRepository()
        {
            return Context;
        }

        [HttpGet("Вивід")]
        public async Task<IEnumerable<BodyTypeReadDto>> GetListAsync()
        {
            return await Context.GetListAsync();
        }
        

    }
}
