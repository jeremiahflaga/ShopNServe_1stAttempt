using ShopNServe.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace ShopNServe.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class ShopNServePageModel : AbpPageModel
{
    protected ShopNServePageModel()
    {
        LocalizationResourceType = typeof(ShopNServeResource);
        ObjectMapperContext = typeof(ShopNServeWebModule);
    }
}
