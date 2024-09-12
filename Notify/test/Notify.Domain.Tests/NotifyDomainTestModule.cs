using Volo.Abp.Modularity;

namespace Notify;

[DependsOn(
    typeof(NotifyDomainModule),
    typeof(NotifyTestBaseModule)
)]
public class NotifyDomainTestModule : AbpModule
{

}
