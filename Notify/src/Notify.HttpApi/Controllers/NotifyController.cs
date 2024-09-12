using Notify.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Notify.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class NotifyController : AbpControllerBase
{
    protected NotifyController()
    {
        LocalizationResource = typeof(NotifyResource);
    }
}
