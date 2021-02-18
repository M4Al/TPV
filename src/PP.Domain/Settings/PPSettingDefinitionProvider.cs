using Volo.Abp.Settings;

namespace PP.Settings
{
    public class PPSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(PPSettings.MySetting1));
        }
    }
}
