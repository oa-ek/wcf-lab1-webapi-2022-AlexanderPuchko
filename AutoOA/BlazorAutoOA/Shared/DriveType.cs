using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorAutoOA.Shared
{
    public class DriveType
    {
        public int DriveTypeId { get; set; }
        public string? DriveTypeName { get; set; }

        public virtual ICollection<Vehicle>? Vehicle { get; set; }
    }
}
