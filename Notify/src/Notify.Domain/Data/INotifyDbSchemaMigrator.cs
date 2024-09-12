using System.Threading.Tasks;

namespace Notify.Data;

public interface INotifyDbSchemaMigrator
{
    Task MigrateAsync();
}
