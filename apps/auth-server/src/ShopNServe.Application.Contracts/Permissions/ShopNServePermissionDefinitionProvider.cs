using ShopNServe.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace ShopNServe.Permissions;

public class ShopNServePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(ShopNServePermissions.GroupName, L("Permission:ShopNServe"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<ShopNServeResource>(name);
    }
}
