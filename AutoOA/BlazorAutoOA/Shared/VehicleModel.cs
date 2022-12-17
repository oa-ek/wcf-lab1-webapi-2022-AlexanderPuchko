using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorAutoOA.Shared
{
    public class VehicleModel
    {
        public int VehicleModelId { get; set; }
        public string? VehicleModelName { get; set; } = string.Empty;

        public int VehicleBrandId { get; set; }
        public VehicleBrand? VehicleBrand { get; set; }

        public virtual ICollection<Vehicle>? Vehicles { get; set; }
    }
}
