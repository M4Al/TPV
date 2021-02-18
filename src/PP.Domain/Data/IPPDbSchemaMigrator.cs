using System.Threading.Tasks;

namespace PP.Data
{
    public interface IPPDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
