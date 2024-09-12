using Volo.Abp.Modularity;

namespace Notify;

public abstract class NotifyApplicationTestBase<TStartupModule> : NotifyTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
