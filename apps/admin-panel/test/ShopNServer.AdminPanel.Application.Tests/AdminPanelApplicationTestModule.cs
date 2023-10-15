using Volo.Abp.Modularity;

namespace ShopNServer.AdminPanel;

[DependsOn(
    typeof(AdminPanelApplicationModule),
    typeof(AdminPanelDomainTestModule)
    )]
public class AdminPanelApplicationTestModule : AbpModule
{

}
