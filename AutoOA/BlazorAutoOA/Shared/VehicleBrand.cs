using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorAutoOA.Shared
{
    public class VehicleBrand
    {
        public int VehicleBrandId { get; set; }
        public string? VehicleBrandName { get; set; } = string.Empty;

        public virtual ICollection<VehicleModel>? VehicleModels { get; set; }
    }
}
