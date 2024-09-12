using Volo.Abp.Modularity;

namespace Notify;

/* Inherit from this class for your domain layer tests. */
public abstract class NotifyDomainTestBase<TStartupModule> : NotifyTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
