using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AutoOA.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleController : ControllerBase
    {
            private static List<Vehicle> vehicle = new List<Vehicle>
            {
                new Vehicle{
                Id = 1,
                Region = "Україна",
                BodyType = "Пікап",
                VehicleModel = "327m",
                ProductionYear = 2003,
                GearBox = "Автомат",
                DriveType = "Передній",
                StateNumber = "AA0001AA",
                NumberOfSeats = 4,
                NumberOfDoors = 4,
                Price_USD = 0,
                Price_UAH = 0,
                Price_EUR = 0,
                isNew = true,
                MileageIconPath = "..",
                Mileage = 1000,
                VehicleIconPath = "...",
                FuelType = "Дизель",
                Color = "Black",
                Description = "hfhfhfhf",
                User = "Alexander Puchko"
                },
                new Vehicle{
                Id = 2,
                Region = "Україна",
                BodyType = "Пікап",
                VehicleModel = "327m",
                ProductionYear = 2003,
                GearBox = "Автомат",
                DriveType = "Передній",
                StateNumber = "AA0001AA",
                NumberOfSeats = 4,
                NumberOfDoors = 4,
                Price_USD = 0,
                Price_UAH = 0,
                Price_EUR = 0,
                isNew = true,
                MileageIconPath = "..",
                Mileage = 1000,
                VehicleIconPath = "...",
                FuelType = "Дизель",
                Color = "Black",
                Description = "hfhfhfhf",
                User = "Alexander Puchko"
                }
            };




        [HttpGet]
        public async Task<ActionResult<List<Vehicle>>> Get()
        {
            
            return Ok(vehicle);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Vehicle>> Get( int id)
        {
            var vehicles = vehicle.Find(v => v.Id == id);
            if (vehicles == null)
                return BadRequest("Машина відсутня");
            return Ok(vehicles);
        }


        [HttpPost]
        public async Task<ActionResult<List<Vehicle>>> AddVehicle(Vehicle vehicles)
        {
            vehicle.Add(vehicles);
            return Ok(vehicle);
        }

        [HttpPut]
        public async Task<ActionResult<List<Vehicle>>> UpdateVehicle(Vehicle request)
        {
            var vehicles = vehicle.Find(v => v.Id == request.Id);
            if (vehicles == null)
                return BadRequest("Машина відсутня");

            vehicles.Region = request.Region;
            vehicles.BodyType = request.BodyType;
            vehicles.VehicleModel = request.VehicleModel;
            vehicles.ProductionYear = request.ProductionYear;
            vehicles.GearBox = request.GearBox;
            vehicles.DriveType = request.DriveType;
            vehicles.StateNumber = request.StateNumber;
            vehicles.NumberOfSeats = request.NumberOfSeats;
            vehicles.NumberOfDoors = request.NumberOfDoors;
            vehicles.Price_USD = request.Price_USD;
            vehicles.Price_UAH = request.Price_UAH;
            vehicles.Price_EUR = request.Price_EUR;
            vehicles.isNew = request.isNew;
            vehicles.MileageIconPath = request.MileageIconPath;
            vehicles.Mileage = request.Mileage;
            vehicles.VehicleIconPath = request.VehicleIconPath;
            vehicles.FuelType = request.FuelType;
            vehicles.Color = request.Color;
            vehicles.Description = request.Description;
            vehicles.User = request.User;


            return Ok(vehicles);
        }


        [HttpDelete("{id}")]
        public async Task<ActionResult<Vehicle>> Delete(int id)
        {
            var vehicles = vehicle.Find(v => v.Id == id);
            if (vehicles == null)
                return BadRequest("Машина відсутня");

            vehicle.Remove(vehicles);
            return Ok(vehicle);
        }

    }
}
