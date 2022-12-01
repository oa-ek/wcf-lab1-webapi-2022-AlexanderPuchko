using AutoOA.Core;

namespace AutoOA.Repository.Dto.DriveTypeDto
{
    public class DriveTypeReadDto
    {
        public int DriveTypeId { get; set; }
        public string? DriveTypeName { get; set; }

        public ICollection<Vehicle>? Vehicle { get; set; }
    }
}
