using AutoOA.Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AutoOA.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BodyTypeAPIController : ControllerBase
    {
        private readonly ILogger<BodyTypeAPIController> _logger;
        private readonly AutoOADbContext Context;

        public BodyTypeAPIController(ILogger<BodyTypeAPIController> logger, AutoOADbContext context)
        {
            _logger = logger;
            Context = context;
        }


        [HttpGet]
        public async Task<ActionResult<List<BodyType>>> Get()
        {
            return Ok(await Context.BodyTypes.ToListAsync());
        }


        [HttpGet]
        public AutoOADbContext GetAutoOADbContext()
        {
            return Context;
        }

    }
}
