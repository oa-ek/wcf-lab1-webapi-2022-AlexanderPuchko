using System.ComponentModel.DataAnnotations;

namespace AutoOA.Repository.Dto.DriveTypeDto
{
    public class DriveTypeCreateDto
    {
        [Required(ErrorMessage = "Введіть назву")]
        [StringLength(32, ErrorMessage = "Must be between 1 and 32 characters", MinimumLength = 1)]
        public string? DriveTypeName { get; set; }
    }
}
