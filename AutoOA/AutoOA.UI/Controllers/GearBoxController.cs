using AutoOA.Core;
using AutoOA.Repository.Dto.GearBoxDto;
using AutoOA.Repository.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace AutoOA.UI.Controllers
{
    public class GearBoxController : Controller
    {
        private readonly ILogger<GearBoxController> _logger;
        private readonly GearBoxRepository _GearBoxRepository;
        public GearBoxController(ILogger<GearBoxController> logger, GearBoxRepository GearBoxRepository)
        {
            _logger = logger;
            _GearBoxRepository = GearBoxRepository;
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Create(GearBoxCreateDto gearBoxDto)
        {
            if (ModelState.IsValid)
            {
                var bodyType = await _GearBoxRepository.AddGearBoxAsync(new GearBox
                {
                    GearBoxName = gearBoxDto.GearBoxName
                });
                return RedirectToAction("Index", "GearBox", new { id = bodyType.GearBoxId });
            }
            return View(gearBoxDto);
        }
    }
}
