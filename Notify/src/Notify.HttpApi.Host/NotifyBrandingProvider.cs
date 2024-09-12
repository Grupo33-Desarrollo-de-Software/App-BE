using Microsoft.Extensions.Localization;
using Notify.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Notify;

[Dependency(ReplaceServices = true)]
public class NotifyBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<NotifyResource> _localizer;

    public NotifyBrandingProvider(IStringLocalizer<NotifyResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
