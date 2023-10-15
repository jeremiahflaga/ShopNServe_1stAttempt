using ShopNServer.AdminPanel.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace ShopNServer.AdminPanel.Web.Pages;

public abstract class AdminPanelPageModel : AbpPageModel
{
    protected AdminPanelPageModel()
    {
        LocalizationResourceType = typeof(AdminPanelResource);
    }
}
