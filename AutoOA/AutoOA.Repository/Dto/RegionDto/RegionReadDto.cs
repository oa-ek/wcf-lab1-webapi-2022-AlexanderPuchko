using AutoOA.Core;

namespace AutoOA.Repository.Dto.RegionDto
{
    public class RegionReadDto
    {
        public int RegionId { get; set; }
        public string? RegionName { get; set; }

        public virtual ICollection<Vehicle>? Vehicles { get; set; }
    }
}
