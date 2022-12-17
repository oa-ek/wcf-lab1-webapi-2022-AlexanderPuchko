using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorAutoOA.Shared
{
    public class Region
    {
        public int RegionId { get; set; }
        public string? RegionName { get; set; }

        public virtual ICollection<Vehicle>? Vehicle { get; set; }
    }
}
