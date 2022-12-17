using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorAutoOA.Shared
{
    public class SalesData
    {
        public int SalesDataId { get; set; }

        public int VehicleId { get; set; }
        public Vehicle? Vehicle { get; set; }

        public DateTime CreatedOn { get; set; } = DateTime.Now; // День створення оголошення
        public DateTime UpdatedOn { get; set; } // День оновлення оголошення
    }
}
