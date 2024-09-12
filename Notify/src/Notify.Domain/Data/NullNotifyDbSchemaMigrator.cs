using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Notify.Data;

/* This is used if database provider does't define
 * INotifyDbSchemaMigrator implementation.
 */
public class NullNotifyDbSchemaMigrator : INotifyDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
