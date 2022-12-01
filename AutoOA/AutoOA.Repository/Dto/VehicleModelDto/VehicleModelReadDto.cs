using AutoOA.Core;

namespace AutoOA.Repository.Dto.VehicleModelDto
{
    public class VehicleModelReadDto
    {
        public int VehicleModelId { get; set; }
        public string? VehicleModelName { get; set; }

        public int VehicleBrandId { get; set; }
        public VehicleBrand VehicleBrand { get; set; }

        public ICollection<Vehicle> Vehicle { get; set; }
    }
}
