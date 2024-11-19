using .EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace ;

[DependsOn(
    typeof(EntityFrameworkCoreTestModule)
    )]
public class DomainTestModule : AbpModule
{

}
