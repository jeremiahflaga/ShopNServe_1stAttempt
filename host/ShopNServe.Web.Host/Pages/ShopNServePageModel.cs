using ShopNServe.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace ShopNServe.Pages;

public abstract class ShopNServePageModel : AbpPageModel
{
    protected ShopNServePageModel()
    {
        LocalizationResourceType = typeof(ShopNServeResource);
    }
}
