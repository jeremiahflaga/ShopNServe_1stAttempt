using Volo.Abp.Reflection;

namespace ShopNServe.Permissions;

public class ShopNServePermissions
{
    public const string GroupName = "ShopNServe";

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(ShopNServePermissions));
    }
}
