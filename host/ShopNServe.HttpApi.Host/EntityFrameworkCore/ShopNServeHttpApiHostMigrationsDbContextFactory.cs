using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace ShopNServe.EntityFrameworkCore;

public class ShopNServeHttpApiHostMigrationsDbContextFactory : IDesignTimeDbContextFactory<ShopNServeHttpApiHostMigrationsDbContext>
{
    public ShopNServeHttpApiHostMigrationsDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<ShopNServeHttpApiHostMigrationsDbContext>()
            .UseNpgsql(configuration.GetConnectionString("ShopNServe"));

        return new ShopNServeHttpApiHostMigrationsDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
