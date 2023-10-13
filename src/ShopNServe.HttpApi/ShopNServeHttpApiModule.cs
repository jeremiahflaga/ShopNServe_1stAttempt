using Localization.Resources.AbpUi;
using ShopNServe.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace ShopNServe;

[DependsOn(
    typeof(ShopNServeApplicationContractsModule),
    typeof(AbpAspNetCoreMvcModule))]
public class ShopNServeHttpApiModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        PreConfigure<IMvcBuilder>(mvcBuilder =>
        {
            mvcBuilder.AddApplicationPartIfNotExists(typeof(ShopNServeHttpApiModule).Assembly);
        });
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<ShopNServeResource>()
                .AddBaseTypes(typeof(AbpUiResource));
        });
    }
}
