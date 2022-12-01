using AutoOA.Core;

namespace AutoOA.Repository.Dto.BodyTypeDto
{
    public class BodyTypeReadDto
    {
        public int BodyTypeId { get; set; }
        public string? BodyTypeName { get; set; }
        public string? IconPath { get; set; }

        public ICollection<Vehicle>? Vehicle { get; set; }
    }
}
