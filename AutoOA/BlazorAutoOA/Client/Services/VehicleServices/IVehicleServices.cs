using AutoOA.Core;
using DriveType = AutoOA.Core.DriveType;

namespace BlazorAutoOA.Client.Services.VehicleServices
{
    public interface IVehicleServices
    {
        List<Vehicle> Vehicles { get; set; }
        List<Region> Regions { get; set; }
        List<BodyType> BodyTypes { get; set; }
        List<VehicleModel> VehicleModels { get; set; }
        List<GearBox> GearBoxs { get; set; }
        List<DriveType> DriveTypes { get; set; }
        List<FuelType> FuelTypes { get; set; }
        List<SalesData> SalesDatas { get; set; }
        List<User> Users { get; set; }

        Task GetVehicles();
        Task GetRegionss();
        Task GetBodyTypes();
        Task GetVehicleModels();
        Task GetGearBoxs();
        Task GetDriveTypes();
        Task GetFuelTypes();
        Task GetSalesDatas();
        Task GetUsers();


        Task<Vehicle> GetSingleVehicle(int id);
        



    }
}
