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
        private readonly AutoOADbContext _ctx;

        public SalesDataAPIController(ILogger<SalesDataAPIController> logger, SalesDataRepository context, AutoOADbContext ctx)
        {
            _logger = logger;
            Context = context;
            _ctx = ctx;
        }
        [HttpGet("All-Data")]
        public async Task<IEnumerable<SalesDataReadDto>> GetListSalesData()
        {
            return await Context.GetListAsync();
        }

        [HttpGet("One-Data{id}")]
        public async Task<SalesDataReadDto> GetSalesDataId(int id)
        {
            return await Context.GetAsync(id);
        }

        [HttpPost("Create-Data")]
        public async Task<int> CreateSalesData(SalesDataCreateDto salesDataDto)
        {
            return await Context.CreateAsync(salesDataDto);
        }

        [HttpPut("Update-Data{id}")]
        public async Task PutRegion(int id, [FromBody] SalesDataCreateDto salesDataDto)
        {
            await Context.Update(id, salesDataDto);
        }

        [HttpDelete("Delete-Data{id}")]
        public async Task<IActionResult> DeleteSalesData(int id)
        {
            var item = await _ctx.Regions.FindAsync(id);

            if (item is null)
            {
                return NotFound();
            }
            await Context.DeleteSalesDataAsync(id);

            return NoContent();
        }
    }
}
