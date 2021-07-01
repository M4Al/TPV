using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace PP.Attractions
{
    public class AttractionAppService :
            CrudAppService<
            Attraction, //The Attraction entity
            AttractionDto, //Used to show attractions
            Guid, //Primary key of the attraction entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateAttractionDto>, //Used to create/update a Attraction
        IAttractionAppService //implement the IAttractionAppService
    {
        public AttractionAppService(IRepository<Attraction, Guid> repository)
            : base(repository)
        {

        }
    }
}
