using System.ComponentModel.DataAnnotations;

namespace AutoOA.Core
{
    public class VehicleBrand
    {
        [Key]
        public int VehicleBrandId { get; set; }
        public string? VehicleBrandName { get; set; }

        public virtual ICollection<VehicleModel>? VehicleModels { get; set; }
    }
}