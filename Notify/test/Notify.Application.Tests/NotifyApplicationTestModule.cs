using Volo.Abp.Modularity;

namespace Notify;

[DependsOn(
    typeof(NotifyApplicationModule),
    typeof(NotifyDomainTestModule)
)]
public class NotifyApplicationTestModule : AbpModule
{

}
