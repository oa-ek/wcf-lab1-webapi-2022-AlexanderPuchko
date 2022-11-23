using AutoOA.Core;
using AutoOA.Repository.Dto.RegionDto;
using AutoOA.Repository.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace AutoOA.UI.Controllers
{
    public class RegionController : Controller
    {
        private readonly ILogger<RegionController> _logger;
        private readonly RegionRepository _RegionRepository;
        public RegionController(ILogger<RegionController> logger, RegionRepository RegionRepository)
        {
            _logger = logger;
            _RegionRepository = RegionRepository;
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Create(RegionCreateDto reregionDto)
        {
            if (ModelState.IsValid)
            {
                var fuelType = await _RegionRepository.AddRegionAsync(new Region
                {
                    RegionName = reregionDto.RegionName
                });
                return RedirectToAction("Index", "Region", new { id = fuelType.RegionId });
            }
            return View(reregionDto);
        }
    }
}
