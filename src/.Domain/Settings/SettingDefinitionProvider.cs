using Volo.Abp.Settings;

namespace .Settings;

public class SettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(Settings.MySetting1));
    }
}
