using AutoOA.Core;

namespace AutoOA.Repository.Dto.VehicleDto
{
    public class VehicleReadDto
    {
        public int VehicleId { get; set; }
        public string? RegionId { get; set; }
        public Region? Region { get; set; }
        public string? BodyTypeId { get; set; }
        public BodyType? BodyType { get; set; }
        public string? VehicleModelId { get; set; }
        public VehicleModel? VehicleModel { get; set; }
        public short ProductionYear { get; set; }
        public string GearBoxId { get; set; }
        public GearBox? GearBox { get; set; }
        public string DriveTypeId { get; set; }
        public Core.DriveType? DriveType { get; set; }
        public string? StateNumber { get; set; }        
        public int NumberOfSeats { get; set; }
        public int NumberOfDoors { get; set; }
        public decimal Price_USD { get; set; }
        public decimal Price_UAH { get; set; } 
        public decimal Price_EUR { get; set; }
        public bool isNew { get; set; }
        public string MileageIconPath { get; set; }
        public int Mileage { get; set; }
        public string? VehicleIconPath { get; set; }
        public string FuelTypeId { get; set; }
        public FuelType? FuelType { get; set; }
        public string? Color { get; set; }
        public string? Description { get; set; }        
        public SalesData? SalesData { get; set; }
        public string? UserId { get; set; }
        public User? User { get; set; }
    }
}
