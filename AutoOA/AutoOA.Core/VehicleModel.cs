using System.ComponentModel.DataAnnotations;

namespace AutoOA.Core
{
    public class VehicleModel
    {
        [Key]
        public int VehicleModelId { get; set; }
        public string? VehicleModelName { get; set; } = string.Empty;

        public int VehicleBrandId { get; set; }
        public VehicleBrand VehicleBrand { get; set; }

        public virtual ICollection<Vehicle> Vehicles { get; set; }
    }
}