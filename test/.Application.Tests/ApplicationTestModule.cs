using Volo.Abp.Modularity;

namespace ;

[DependsOn(
    typeof(ApplicationModule),
    typeof(DomainTestModule)
    )]
public class ApplicationTestModule : AbpModule
{

}
