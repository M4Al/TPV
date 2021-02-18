using Volo.Abp.Modularity;

namespace PP
{
    [DependsOn(
        typeof(PPApplicationModule),
        typeof(PPDomainTestModule)
        )]
    public class PPApplicationTestModule : AbpModule
    {

    }
}