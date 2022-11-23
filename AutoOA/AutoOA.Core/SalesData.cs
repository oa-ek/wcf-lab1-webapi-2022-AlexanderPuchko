using System.ComponentModel.DataAnnotations;

namespace AutoOA.Core
{
    public class SalesData
    {
        [Key]
        public int SalesDataId { get; set; }

        public int VehicleId { get; set; }
        public Vehicle? Vehicle { get; set; }

        public DateTime CreatedOn { get; set; } = DateTime.Now; // День створення оголошення
        public DateTime UpdatedOn { get; set; } // День оновлення оголошення
    }
}