using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace ShopNServe;

[DependsOn(
    typeof(ShopNServeApplicationContractsModule),
    typeof(AbpHttpClientModule))]
public class ShopNServeHttpApiClientModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddHttpClientProxies(
            typeof(ShopNServeApplicationContractsModule).Assembly,
            ShopNServeRemoteServiceConsts.RemoteServiceName
        );

        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<ShopNServeHttpApiClientModule>();
        });

    }
}
