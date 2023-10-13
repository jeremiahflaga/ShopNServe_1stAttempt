using Volo.Abp.Autofac;
using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace ShopNServe;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(ShopNServeHttpApiClientModule),
    typeof(AbpHttpClientIdentityModelModule)
    )]
public class ShopNServeConsoleApiClientModule : AbpModule
{

}
