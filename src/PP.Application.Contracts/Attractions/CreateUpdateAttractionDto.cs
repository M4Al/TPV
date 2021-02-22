using System;
using System.ComponentModel.DataAnnotations;

namespace PP.Attractions
{
    public class CreateUpdateAttractionDto
    {
        [Required]
        [StringLength(128)]
        public string Name { get; set; }
        [Required]
        public AttractionType Type { get; set; } = AttractionType.Undefined;
    }
}
