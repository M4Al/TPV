using PP.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace PP.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class PPController : AbpController
    {
        protected PPController()
        {
            LocalizationResource = typeof(PPResource);
        }
    }
}