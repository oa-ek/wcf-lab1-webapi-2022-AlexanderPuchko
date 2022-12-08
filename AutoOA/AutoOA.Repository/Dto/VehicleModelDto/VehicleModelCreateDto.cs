using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AutoOA.Repository.Dto.VehicleModelDto
{
    public class VehicleModelCreateDto
    {
        [Required(ErrorMessage = "Введіть назву")]
        public string? VehicleModelName { get; set; }
    }
}
