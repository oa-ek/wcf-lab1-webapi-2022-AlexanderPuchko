using System.Net.Http.Json;

namespace BlazorAutoOA.Client.Services.VehicleServices
{
    public class VehicleServices : IVehicleServices
    {
        private readonly HttpClient _http;

        public VehicleServices(HttpClient http)
        {
            _http = http;
        }



        public List<Vehicle> Vehicles { get; set; } = new List<Vehicle>();
        public List<Region> Regions { get; set; } = new List<Region>();
        public List<BodyType> BodyTypes { get; set; } = new List<BodyType>();
        public List<VehicleModel> VehicleModels { get; set; } = new List<VehicleModel>();
        public List<GearBox> GearBoxs { get; set; } = new List<GearBox>();
        public List<BlazorAutoOA.Shared.DriveType> DriveTypes { get; set; } = new List<BlazorAutoOA.Shared.DriveType>();
        public List<FuelType> FuelTypes { get; set; } = new List<FuelType>();
        public List<SalesData> SalesDatas { get; set; } = new List<SalesData>();
        public List<User> Users { get; set; } = new List<User>();

        public Task GetBodyTypes()
        {
            throw new NotImplementedException();
        }

        public Task GetDriveTypes()
        {
            throw new NotImplementedException();
        }

        public Task GetFuelTypes()
        {
            throw new NotImplementedException();
        }

        public Task GetGearBoxs()
        {
            throw new NotImplementedException();
        }

        public Task GetRegionss()
        {
            throw new NotImplementedException();
        }

        public Task GetSalesDatas()
        {
            throw new NotImplementedException();
        }

        public Task<Vehicle> GetSingleVehicle(int id)
        {
            throw new NotImplementedException();
        }

        public Task GetUsers()
        {
            throw new NotImplementedException();
        }

        public Task GetVehicleModels()
        {
            throw new NotImplementedException();
        }

        public async Task GetVehicles()
        {
            var result = await _http.GetFromJsonAsync<List<Vehicle>>("api/vehicle");
            if (result != null)
                Vehicles = result; 
        }
    }
}
