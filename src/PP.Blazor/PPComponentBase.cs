using PP.Localization;
using Volo.Abp.AspNetCore.Components;

namespace PP.Blazor
{
    public abstract class PPComponentBase : AbpComponentBase
    {
        protected PPComponentBase()
        {
            LocalizationResource = typeof(PPResource);
        }
    }
}
