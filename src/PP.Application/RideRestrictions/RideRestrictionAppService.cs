using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace PP.RideRestrictions
{
    public class RideRestrictionAppService :
        CrudAppService<
            RideRestriction, // The RideRestriction entity
            RideRestrictionDto, // usde to show the restrictions
            Guid, //Primary key of the riderestriction Entity
            PagedAndSortedResultRequestDto, // Used for paging and sorting
            CreateUpdateRideRestrictionDto>, // Used to create/ update riderestrictions
        IRideRestrictionAppService // Implement the IRiderestrictionAppService
    {
        public RideRestrictionAppService(IRepository<RideRestriction, Guid>repository)
            : base(repository)
        {

        }
    }
}
