using Notify.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Notify.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(NotifyEntityFrameworkCoreModule),
    typeof(NotifyApplicationContractsModule)
)]
public class NotifyDbMigratorModule : AbpModule
{
}
