using PP.Attractions;
using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities.Auditing;

namespace PP.RideRestrictions
{
    public class RideRestriction :AuditedAggregateRoot<Guid>
    {
        public string Name { get; set; }
        public RideRestrictionType Type { get; set; }
        public int ValueLow { get; set; }
        public int ValueHigh { get; set; }

        public ICollection<Attraction> Attractions { get; set; }

        public RideRestriction()
        {
            Attractions = new List<Attraction>();
        }
    }
}
