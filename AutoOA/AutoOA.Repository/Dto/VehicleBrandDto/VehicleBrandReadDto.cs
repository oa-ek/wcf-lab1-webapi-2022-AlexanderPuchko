using AutoOA.Core;

namespace AutoOA.Repository.Dto.VehicleBrandDto
{
    public class VehicleBrandReadDto
    {
        public int VehicleBrandId { get; set; }
        public string? VehicleBrandName { get; set; }

        public ICollection<VehicleModel> VehicleModels { get; set; }
    }
}
