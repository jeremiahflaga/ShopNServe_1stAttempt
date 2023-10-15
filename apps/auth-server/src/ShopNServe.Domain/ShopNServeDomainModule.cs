using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace ShopNServe;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(ShopNServeDomainSharedModule)
)]
public class ShopNServeDomainModule : AbpModule
{

}
