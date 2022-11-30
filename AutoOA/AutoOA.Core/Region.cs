﻿using System.ComponentModel.DataAnnotations;

namespace AutoOA.Core
{
    public class Region
    {
        [Key]
        public int RegionId { get; set; }
        public string? RegionName { get; set; } = string.Empty;

        public virtual ICollection<Vehicle>? Vehicles { get; set; }
    }
}