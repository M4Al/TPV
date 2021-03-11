using PP.RideRestrictions;
using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities.Auditing;

namespace PP.Attractions
{
    public class Attraction : AuditedAggregateRoot<Guid>
    {
        public string Name { get; set; }
        public AttractionType Type { get; set; }

        public ICollection<RideRestriction> RideRestrictions { get; set; }

        public Attraction()
        {
            RideRestrictions = new List<RideRestriction>();
        }
    
    }

}
