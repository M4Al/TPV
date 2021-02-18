using PP.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace PP
{
    [DependsOn(
        typeof(PPEntityFrameworkCoreTestModule)
        )]
    public class PPDomainTestModule : AbpModule
    {

    }
}