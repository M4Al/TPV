using System;
using System.Linq;
using System.Threading.Tasks;
using PP.Attractions;
using PP.RideRestrictions;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace PP
{
    public class PPDataSeedContributor : IDataSeedContributor, ITransientDependency
    {
        private const string ELRIO = "El Rio";
        private readonly IRepository<Attraction, Guid> _attractionRepository;
        private readonly IRepository<RideRestriction, Guid> _rideRestrictionRepository;
                        
        public PPDataSeedContributor(
            IRepository<Attraction, Guid> attractionRepository,
            IRepository<RideRestriction, Guid> ridestrictionRepository
        )
        {
            _attractionRepository = attractionRepository;
            _rideRestrictionRepository = ridestrictionRepository;

        }

        public async Task SeedAsync(DataSeedContext context)
        {
            if (await _attractionRepository.GetCountAsync() > 0)
            {
                return;
            }

            var bobExpress = await _attractionRepository.InsertAsync(new Attraction
            {
                Name = "Bob Express",
                Type = AttractionType.Rollercoaster,
            }
             );

            var elRio = await _attractionRepository.InsertAsync(new Attraction
            {
                Name = ELRIO,
                Type = AttractionType.Waterattractie,
            }

             );

            if (await _rideRestrictionRepository.GetCountAsync() > 0)
            {
                return;
            }

            var Volwassen12m = await _rideRestrictionRepository.InsertAsync(new RideRestriction
            {
                Name = "1.2m Volwassen",
                Type = RideRestrictionType.Adult,
                ValueLow = 1200,
                ValueHigh = 3000
            }
            );

            var begeleiding = await _rideRestrictionRepository.InsertAsync(new RideRestriction
            {
                Name = "90 cm - 1m20 begeleiding",
                Type = RideRestrictionType.Supervision,
                ValueLow = 900,
                ValueHigh = 1200
            }
            );

            elRio.RideRestrictions.Add(Volwassen12m);
            elRio.RideRestrictions.Add(begeleiding);

            begeleiding.Attractions.Add(bobExpress);


        }
    }
}
