using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace ShopNServe.PublicWeb.Web;

[Dependency(ReplaceServices = true)]
public class PublicWebBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "PublicWeb";
}
