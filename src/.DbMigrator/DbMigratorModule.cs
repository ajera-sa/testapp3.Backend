using .EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace .DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(EntityFrameworkCoreModule),
    typeof(ApplicationContractsModule)
)]
public class DbMigratorModule : AbpModule
{

}
