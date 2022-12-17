using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorAutoOA.Shared
{
    public class User
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        public virtual ICollection<Vehicle>? Vehicles { get; set; }
    }
}
