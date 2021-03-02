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
            if(await _attractionRepository.GetCountAsync() <= 0)
            {
                await _attractionRepository.InsertAsync(new Attraction
                {
                    Name ="Bob Express",
                    Type = AttractionType.Rollercoaster,
                },
                autoSave: true
                );

                await _attractionRepository.InsertAsync(new Attraction
                {
                    Name="El Rio",
                    Type = AttractionType.Waterattractie,
                },
                autoSave: true
                );

                var queryAbleAttractions = await _attractionRepository.GetQueryableAsync();
                Attraction attraction = (Attraction)queryAbleAttractions.Where(p => p.Name.Equals("El Rio"));

                var queryAbleRR = await _rideRestrictionRepository.GetQueryableAsync();
                RideRestriction restriction = (RideRestriction)queryAbleAttractions.Where(p => p.Name.Equals("1.2m Volwassen"));

                attraction.RideRestrictions.Add(restriction);

                }

            if (await _rideRestrictionRepository.GetCountAsync() <= 0)
            {
                await _rideRestrictionRepository.InsertAsync(new RideRestriction
                {
                    Name = "1.2m Volwassen",
                    Type = RideRestrictionType.Adult,
                    ValueLow = 1200,
                    ValueHigh = 3000
                },
                autoSave: true
                );

                await _rideRestrictionRepository.InsertAsync(new RideRestriction
                {
                    Name = "90 cm - 1m20 begeleiding",
                    Type = RideRestrictionType.Supervision,
                    ValueLow = 900,
                    ValueHigh = 1200
                },
                autoSave: true
                );
            }
        }
    }
}
