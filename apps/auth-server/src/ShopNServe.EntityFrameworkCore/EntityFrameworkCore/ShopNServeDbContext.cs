using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace ShopNServe.EntityFrameworkCore;

[ConnectionStringName(ShopNServeDbProperties.ConnectionStringName)]
public class ShopNServeDbContext : AbpDbContext<ShopNServeDbContext>, IShopNServeDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * public DbSet<Question> Questions { get; set; }
     */

    public ShopNServeDbContext(DbContextOptions<ShopNServeDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ConfigureShopNServe();
    }
}
