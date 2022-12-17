using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorAutoOA.Shared
{
    public class BodyType
    {
        public int BodyTypeId { get; set; }
        public string BodyTypeName { get; set; }
        public string IconPath { get; set; } = @"\Images\BodyTypeIcon.png"; //TO DO PRAVKI

        public virtual ICollection<Vehicle>? Vehicle { get; set; }
    }
}
