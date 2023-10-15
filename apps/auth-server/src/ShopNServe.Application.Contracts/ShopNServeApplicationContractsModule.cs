using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace ShopNServe;

[DependsOn(
    typeof(ShopNServeDomainSharedModule),
    typeof(AbpDddApplicationContractsModule),
    typeof(AbpAuthorizationModule)
    )]
public class ShopNServeApplicationContractsModule : AbpModule
{

}
