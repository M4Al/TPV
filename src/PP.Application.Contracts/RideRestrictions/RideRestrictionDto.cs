using System;
using Volo.Abp.Application.Dtos;

namespace PP.RideRestrictions
{
    public class RideRestrictionDto : AuditedEntityDto<Guid>
    {
        public string Name { get; set; }
        public RideRestrictionType Type { get; set; }
        public int ValueLow { get; set; }
        public int ValueHigh { get; set; }
    }
}
