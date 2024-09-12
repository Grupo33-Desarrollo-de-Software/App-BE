using Volo.Abp.Settings;

namespace Notify.Settings;

public class NotifySettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(NotifySettings.MySetting1));
    }
}
