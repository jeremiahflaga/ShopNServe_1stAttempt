using System.Threading.Tasks;
using Volo.Abp.UI.Navigation;

namespace ShopNServe.Web.Menus;

public class ShopNServeMenuContributor : IMenuContributor
{
    public async Task ConfigureMenuAsync(MenuConfigurationContext context)
    {
        if (context.Menu.Name == StandardMenus.Main)
        {
            await ConfigureMainMenuAsync(context);
        }
    }

    private Task ConfigureMainMenuAsync(MenuConfigurationContext context)
    {
        //Add main menu items.
        context.Menu.AddItem(new ApplicationMenuItem(ShopNServeMenus.Prefix, displayName: "ShopNServe", "~/ShopNServe", icon: "fa fa-globe"));

        return Task.CompletedTask;
    }
}
