using System;
using Volo.Abp.Application.Dtos;

namespace PP.Attractions
{
    public class AttractionDto :AuditedEntityDto<Guid>
    {
        public string Name { get; set; }
        public AttractionType Type { get; set; }
    }
}
