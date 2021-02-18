using System;
using System.Collections.Generic;
using System.Text;
using PP.Localization;
using Volo.Abp.Application.Services;

namespace PP
{
    /* Inherit your application services from this class.
     */
    public abstract class PPAppService : ApplicationService
    {
        protected PPAppService()
        {
            LocalizationResource = typeof(PPResource);
        }
    }
}
