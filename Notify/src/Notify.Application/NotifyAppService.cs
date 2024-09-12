using Notify.Localization;
using Volo.Abp.Application.Services;

namespace Notify;

/* Inherit your application services from this class.
 */
public abstract class NotifyAppService : ApplicationService
{
    protected NotifyAppService()
    {
        LocalizationResource = typeof(NotifyResource);
    }
}
