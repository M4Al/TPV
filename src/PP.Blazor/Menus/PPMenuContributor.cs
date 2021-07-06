using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PP.Localization;
using Volo.Abp.Account.Localization;
using Volo.Abp.UI.Navigation;
using Volo.Abp.Users;

namespace PP.Blazor.Menus
{
    public class PPMenuContributor : IMenuContributor
    {
        private readonly IConfiguration _configuration;

        public PPMenuContributor(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task ConfigureMenuAsync(MenuConfigurationContext context)
        {
            if (context.Menu.Name == StandardMenus.Main)
            {
                await ConfigureMainMenuAsync(context);
            }
            else if (context.Menu.Name == StandardMenus.User)
            {
                await ConfigureUserMenuAsync(context);
            }
        }

        private Task ConfigureMainMenuAsync(MenuConfigurationContext context)
        {
            var l = context.GetLocalizer<PPResource>();

            context.Menu.Items.Insert(
                0,
                new ApplicationMenuItem(
                    PPMenus.Home,
                    l["Menu:Home"],
                    "/",
                    icon: "fas fa-home"
                )
            );

            context.Menu.AddItem(
                new ApplicationMenuItem(
                    "Pretparken",
                    l["Menu:PP"],
                    icon: "fa fa-angle-down"
                ).AddItem(
                    new ApplicationMenuItem(
                        "PP.Attractions",
                        l["Menu:Attractions"],
                        url: "/attractions"
                    )
                )
            );

            return Task.CompletedTask;
        }

        private Task ConfigureUserMenuAsync(MenuConfigurationContext context)
        {
            var accountStringLocalizer = context.GetLocalizer<AccountResource>();
            var currentUser = context.ServiceProvider.GetRequiredService<ICurrentUser>();

            var identityServerUrl = _configuration["AuthServer:Authority"] ?? "";

            if (currentUser.IsAuthenticated)
            {
                context.Menu.AddItem(new ApplicationMenuItem(
                    "Account.Manage",
                    accountStringLocalizer["ManageYourProfile"],
                    $"{identityServerUrl.EnsureEndsWith('/')}Account/Manage?returnUrl={_configuration["App:SelfUrl"]}",
                    icon: "fa fa-cog",
                    order: 1000,
                    null));
            }

            return Task.CompletedTask;
        }
    }
}
