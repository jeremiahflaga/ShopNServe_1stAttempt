using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace ShopNServe.EntityFrameworkCore;

public class ShopNServeHttpApiHostMigrationsDbContext : AbpDbContext<ShopNServeHttpApiHostMigrationsDbContext>
{
    public ShopNServeHttpApiHostMigrationsDbContext(DbContextOptions<ShopNServeHttpApiHostMigrationsDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ConfigureShopNServe();
    }
}
