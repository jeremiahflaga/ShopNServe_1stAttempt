using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace ShopNServe.EntityFrameworkCore;

[ConnectionStringName(ShopNServeDbProperties.ConnectionStringName)]
public interface IShopNServeDbContext : IEfCoreDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * DbSet<Question> Questions { get; }
     */
}
