using Volo.Abp.Modularity;

namespace ShopNServe;

[DependsOn(
    typeof(ShopNServeApplicationModule),
    typeof(ShopNServeDomainTestModule)
    )]
public class ShopNServeApplicationTestModule : AbpModule
{

}
