using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace PP.Attractions
{
    public interface IAttractionAppService : IApplicationService
    {
        Task<AttractionDto> GetOne(Guid id);
    }
}
