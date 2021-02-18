using PP.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace PP.Permissions
{
    public class PPPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(PPPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(PPPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<PPResource>(name);
        }
    }
}
