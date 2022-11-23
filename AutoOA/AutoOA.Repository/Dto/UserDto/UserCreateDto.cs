using System.ComponentModel.DataAnnotations;

namespace AutoOA.Repository.Dto.UserDto
{
    public class UserCreateDto
    {
        [Required(ErrorMessage = "Введіть ім'я")]
        [StringLength(32, ErrorMessage = "Must be between 5 and 32 characters", MinimumLength = 5)]
        [RegularExpression("^[a-zA-Z0-9_.-]+@[a-zA-Z0-9-]+.[a-zA-Z0-9-.]+$", ErrorMessage = "Must be a valid email")]
        public string? Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string? Password { get; set; }

        [Required]
        public string? LastName { get; set; }

        [Required]
        public string? FirstName { get; set; }
    }
}
