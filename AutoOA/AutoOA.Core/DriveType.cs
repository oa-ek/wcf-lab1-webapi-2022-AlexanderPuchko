using System.ComponentModel.DataAnnotations;

namespace AutoOA.Core
{
    public class DriveType
    {
        [Key]
        public int DriveTypeId { get; set; }
        public string? DriveTypeName { get; set; } = string.Empty;

        public virtual ICollection<Vehicle>? Vehicle { get; set; }
    }
}
