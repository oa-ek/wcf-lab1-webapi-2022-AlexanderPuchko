using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorAutoOA.Shared
{
    public class GearBox
    {
        public int GearBoxId { get; set; }
        public string? GearBoxName { get; set; }
        public string? IconPath { get; set; } = @"\Images\gearBoxIcon.png";

        public virtual ICollection<Vehicle>? Vehicle { get; set; }
    }
}
