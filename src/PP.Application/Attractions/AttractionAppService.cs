using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace PP.Attractions
{
    public class AttractionAppService :
           ApplicationService, IAttractionAppService
    {
        private readonly IRepository<Attraction, Guid> _attractionRepository;

        public AttractionAppService(IRepository<Attraction, Guid> attractionRepository)
        {
            _attractionRepository = attractionRepository;
        }

        public async Task<AttractionDto> GetOne(Guid id)
        {
            Attraction item =  await _attractionRepository.GetAsync(id);
            return ObjectMapper.Map<Attraction, AttractionDto>(item);
        }
    }
}
