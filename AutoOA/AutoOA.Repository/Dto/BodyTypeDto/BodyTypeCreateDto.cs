using System.ComponentModel.DataAnnotations;

namespace AutoOA.Repository.Dto.BodyTypeDto
{
    public class BodyTypeCreateDto
    {
        [Required(ErrorMessage = "Введіть назву")]
        [StringLength(32, ErrorMessage = "Must be between 1 and 32 characters", MinimumLength = 1)]
        public string? BodyName { get; set; }
    }
}
