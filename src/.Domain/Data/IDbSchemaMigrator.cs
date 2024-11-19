using System.Threading.Tasks;

namespace .Data;

public interface IDbSchemaMigrator
{
    Task MigrateAsync();
}
