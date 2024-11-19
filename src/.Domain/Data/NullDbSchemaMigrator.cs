using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace .Data;

/* This is used if database provider does't define
 * IDbSchemaMigrator implementation.
 */
public class NullDbSchemaMigrator : IDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
