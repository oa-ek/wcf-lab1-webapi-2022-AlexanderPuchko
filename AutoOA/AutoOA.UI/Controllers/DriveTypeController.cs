using AutoOA.Core;
using AutoOA.Repository.Dto.DriveTypeDto;
using AutoOA.Repository.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace AutoOA.UI.Controllers
{
    public class DriveTypeController : Controller
    {
        private readonly ILogger<DriveTypeController> _logger;
        private readonly DriveTypeRepository _driveTypeRepository;
        public DriveTypeController(ILogger<DriveTypeController> logger, DriveTypeRepository bodyTypeRepository)
        {
            _logger = logger;
            _driveTypeRepository = bodyTypeRepository;
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Create(DriveTypeCreateDto driveTypeDto)
        {
            if (ModelState.IsValid)
            {
                var driveType = await _driveTypeRepository.AddDriveTypeAsync(new Core.DriveType
                {
                    DriveTypeName = driveTypeDto.DriveTypeName
                });
                return RedirectToAction("Index", "DriveType", new { id = driveType.DriveTypeId });
            }
            return View(driveTypeDto);
        }
    }
}
