using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace PP.Attractions
{
    public interface IAttractionAppService :
        ICrudAppService< //Defines CRUD methods
            AttractionDto, //Used to show attractions
            Guid, //Primary keyof the book entity
            PagedAndSortedResultRequestDto, //Used for paging and sorting
            CreateUpdateAttractionDto > // Used to create/ update a attraction
    {

    }
}
