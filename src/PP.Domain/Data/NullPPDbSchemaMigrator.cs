using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace PP.Data
{
    /* This is used if database provider does't define
     * IPPDbSchemaMigrator implementation.
     */
    public class NullPPDbSchemaMigrator : IPPDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}