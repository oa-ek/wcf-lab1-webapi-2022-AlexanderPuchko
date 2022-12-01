using AutoOA.Core;

namespace AutoOA.Repository.Dto.FuelTypeDto
{
    public class FuelTypeReadDto
    {
        public int FuelTypeId { get; set; }
        public string? FuelTypeName { get; set; }
        public string? IconPath { get; set; }
        
        public ICollection<Vehicle>? Vehicle { get; set; }
    }
}
