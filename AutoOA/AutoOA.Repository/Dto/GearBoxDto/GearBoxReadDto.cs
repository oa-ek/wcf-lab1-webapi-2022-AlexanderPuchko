using AutoOA.Core;

namespace AutoOA.Repository.Dto.GearBoxDto
{
    public class GearBoxReadDto
    {
        public int GearBoxId { get; set; }
        public string GearBoxName { get; set; }
        public string IconPath { get; set; }
        
        public ICollection<Vehicle> Vehicles { get; set; }
    }
}
