using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace PP.EntityFrameworkCore
{
    [DependsOn(
        typeof(PPEntityFrameworkCoreModule)
        )]
    public class PPEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<PPMigrationsDbContext>();
        }
    }
}
