using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorAutoOA.Shared
{
    public class FuelType
    {
        public int FuelTypeId { get; set; }
        public string? FuelTypeName { get; set; }
        public string? IconPath { get; set; } = @"\Images\fuelTypeIcon.png";

        public virtual ICollection<Vehicle>? Vehicle { get; set; }
    }
}
