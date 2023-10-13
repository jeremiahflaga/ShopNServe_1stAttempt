using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace ShopNServe;

[Dependency(ReplaceServices = true)]
public class ShopNServeBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "ShopNServe";
}
