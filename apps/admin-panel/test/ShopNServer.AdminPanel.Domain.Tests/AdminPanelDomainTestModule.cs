using ShopNServer.AdminPanel.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace ShopNServer.AdminPanel;

[DependsOn(
    typeof(AdminPanelEntityFrameworkCoreTestModule)
    )]
public class AdminPanelDomainTestModule : AbpModule
{

}
