using AutoOA.Core;
using AutoOA.Repository.Dto.SalesDataDto;
using AutoOA.Repository.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AutoOA.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesDataAPIController : ControllerBase
    {
        private readonly ILogger<SalesDataAPIController> _logger;
        private readonly SalesDataRepository Context;

        public SalesDataAPIController(ILogger<SalesDataAPIController> logger, SalesDataRepository context)
        {
            _logger = logger;
            Context = context;
        }

        [HttpGet]
        public SalesDataRepository GetSalesDataRepository()
        {
            return Context;
        }

        [HttpGet("GetHui")]
        public async Task<IEnumerable<SalesDataReadDto>> GetListAsync()
        {
            return await Context.GetListAsync();
        }
        

    }
}
