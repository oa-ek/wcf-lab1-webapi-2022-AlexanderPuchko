using Microsoft.AspNetCore.Identity;

namespace AutoOA.Core
{
    public class User : IdentityUser
    {
        public string? FirstName { get; set; } = string.Empty;
        public string? LastName { get; set; } = string.Empty;

        public virtual ICollection<Vehicle> Vehicles { get; set; }
    }
}
