using ShopNServe.PublicWeb.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace ShopNServe.PublicWeb.Web.Pages;

public abstract class PublicWebPageModel : AbpPageModel
{
    protected PublicWebPageModel()
    {
        LocalizationResourceType = typeof(PublicWebResource);
    }
}
