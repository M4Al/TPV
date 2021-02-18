using PP.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace PP.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(PPEntityFrameworkCoreDbMigrationsModule),
        typeof(PPApplicationContractsModule)
        )]
    public class PPDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
