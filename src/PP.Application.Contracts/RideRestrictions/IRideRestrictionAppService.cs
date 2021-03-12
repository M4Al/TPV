using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace PP.RideRestrictions
{
    public interface IRideRestrictionAppService :
        ICrudAppService< // Definte CRUD methods
            RideRestrictionDto, // usde to show the restrictions
            Guid, //Primary key of the riderestriction Entity
            PagedAndSortedResultRequestDto, // Used for paging and sorting
            CreateUpdateRideRestrictionDto> // Used to create/ update riderestrictions
    {
    }
}
