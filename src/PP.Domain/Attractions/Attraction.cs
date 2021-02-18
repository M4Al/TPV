using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace PP.Attractions
{
    public class Attraction : AuditedAggregateRoot<Guid>
    {
        public string Name { get; set; }
        public AttractionType Type { get; set; }
    }
}
