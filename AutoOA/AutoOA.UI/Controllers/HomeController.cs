using AutoOA.UI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using AutoOA.Repository.Repositories;
using AutoOA.Core;
using Microsoft.EntityFrameworkCore;

namespace AutoOA.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly VehicleRepository _vehicleRepository;
        private readonly BodyTypeRepository _bodyTypeRepository;

        private readonly AutoOADbContext _ctx;

        public HomeController(ILogger<HomeController> logger, VehicleRepository vehicleRepository,
            BodyTypeRepository bodyTypeRepository, AutoOADbContext ctx)
        {
            _logger = logger;
            _vehicleRepository = vehicleRepository;
            _bodyTypeRepository = bodyTypeRepository;
            _ctx = ctx;
        }

        public IActionResult Index()
        {
            return View(_vehicleRepository.GetVehicles());
        }

        public IActionResult IndexUAH()
        {
            return View(_vehicleRepository.GetVehicles());
        }

        public IActionResult IndexEUR()
        {
            return View(_vehicleRepository.GetVehicles());
        }

        [Route("Home/Index")]
        [HttpGet]
        public async Task<IActionResult> Index(string searchString)
        {
            ViewData["GetVehicleDetails"] = searchString;

            var brands = from b in _ctx.Vehicles
                         select b;

            if (!String.IsNullOrEmpty(searchString))
            {
                brands = brands.Where(s => s.VehicleModel.VehicleBrand.VehicleBrandName.Contains(searchString));
            }
            return View(await brands.Include(x => x.VehicleModel).ThenInclude(x => x.VehicleBrand).
                Include(x => x.BodyType).
                Include(x => x.DriveType).
                Include(x => x.FuelType).
                Include(x => x.GearBox).
                Include(x => x.Region).
                Include(x => x.User).
                Include(x => x.SalesData).ToListAsync());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}