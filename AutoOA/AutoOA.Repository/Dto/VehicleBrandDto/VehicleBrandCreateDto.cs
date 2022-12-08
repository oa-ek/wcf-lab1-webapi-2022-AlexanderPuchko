using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoOA.Repository.Dto.VehicleBrandDto
{
    public class VehicleBrandCreateDto
    {
        [Required(ErrorMessage = "Введіть назву")]
        public string? VehicleBrandName { get; set; }

    }
}
