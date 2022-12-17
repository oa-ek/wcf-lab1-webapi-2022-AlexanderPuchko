using AutoOA.Core;
using AutoOA.Repository.Dto.FuelTypeDto;
using AutoOA.Repository.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace AutoOA.UI.Controllers
{
    public class FuelTypeController : Controller
    {
        private readonly ILogger<FuelTypeController> _logger;
        private readonly FuelTypeRepository _FuelTypeRepository;
        public FuelTypeController(ILogger<FuelTypeController> logger, FuelTypeRepository fuelTypeRepository)
        {
            _logger = logger;
            _FuelTypeRepository = fuelTypeRepository;
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Create(FuelTypeCreateDto fuelTypeDto)
        {
            if (ModelState.IsValid)
            {
                var fuelType = await _FuelTypeRepository.AddFuelTypeAsync(new FuelType
                {
                    FuelTypeName = fuelTypeDto.FuelTypeName
                });
                return RedirectToAction("Index", "FuelType", new { id = fuelType.FuelTypeId });
            }
            return View(fuelTypeDto);
        }
    }
}
