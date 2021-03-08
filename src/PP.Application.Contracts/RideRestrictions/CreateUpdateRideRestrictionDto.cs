using System;
using System.ComponentModel.DataAnnotations;

namespace PP.RideRestrictions
{
    public class CreateUpdateRideRestrictionDto
    {
        [Required]
        [StringLength(128)]
        public string Name { get; set; }

        [Required]
        public RideRestrictionType Type { get; set; } = RideRestrictionType.Undefined;
        [Required]
        public int ValueLow { get; set; } = 0;

        [Required]
        public int ValueHigh { get; set; } = 0;
    }
}
