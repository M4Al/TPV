using System.Collections.Generic;
using Volo.Abp.Bundling;

namespace PP.Blazor
{
    public class PPBundleContributor : IBundleContributor
    {
        public void AddScripts(BundleContext context)
        {
        }

        public void AddStyles(BundleContext context)
        {
            var excludeThemeFromBundle = bool.Parse(context.Parameters.GetValueOrDefault("ExcludeThemeFromBundle"));
            context.Add("styles/PpTheme.css", excludeFromBundle: excludeThemeFromBundle);
            context.Add("main.css", true);
        }
    }
}