using ShopNServe.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace ShopNServe;

/* Domain tests are configured to use the EF Core provider.
 * You can switch to MongoDB, however your domain tests should be
 * database independent anyway.
 */
[DependsOn(
    typeof(ShopNServeEntityFrameworkCoreTestModule)
    )]
public class ShopNServeDomainTestModule : AbpModule
{

}
