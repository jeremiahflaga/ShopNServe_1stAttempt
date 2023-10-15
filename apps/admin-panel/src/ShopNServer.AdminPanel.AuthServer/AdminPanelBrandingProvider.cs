using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace ShopNServer.AdminPanel;

[Dependency(ReplaceServices = true)]
public class AdminPanelBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "AdminPanel";
}
