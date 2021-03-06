﻿using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace PP.Blazor
{
    [Dependency(ReplaceServices = true)]
    public class PPBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "PP";
    }
}
