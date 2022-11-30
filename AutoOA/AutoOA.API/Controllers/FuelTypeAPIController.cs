using AutoOA.Core;
using AutoOA.Repository.Dto.FuelTypeDto;
using AutoOA.Repository.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AutoOA.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FuelTypeAPIController : ControllerBase
    {
        private readonly ILogger<FuelTypeAPIController> _logger;
        private readonly FuelTypeRepository Context;

        public FuelTypeAPIController(ILogger<FuelTypeAPIController> logger, FuelTypeRepository context)
        {
            _logger = logger;
            Context = context;
        }

        [HttpGet]
        public FuelTypeRepository GetFuelTypeRepository()
        {
            return Context;
        }

        [HttpGet("GetHui")]
        public async Task<IEnumerable<FuelTypeReadDto>> GetListAsync()
        {
            return await Context.GetListAsync();
        }
        

    }
}
