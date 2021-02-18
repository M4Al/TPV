using System;
using System.Threading.Tasks;
using PP.Attractions;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace PP
{
    public class AttractionDataSeedContributor : IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<Attraction, Guid> _attractionRepository;

        public AttractionDataSeedContributor(IRepository<Attraction, Guid> attractionRepository)
        {
            _attractionRepository = attractionRepository;
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
                
            }
        }
    }
}
