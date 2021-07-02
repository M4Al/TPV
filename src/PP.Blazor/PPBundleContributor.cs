using System.Collections.Generic;
using Volo.Abp.Bundling;

namespace PP.Blazor
{
    /* Add your global styles/scripts here.
     * See https://docs.abp.io/en/abp/latest/UI/Blazor/Global-Scripts-Styles to learn how to use it
     */
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