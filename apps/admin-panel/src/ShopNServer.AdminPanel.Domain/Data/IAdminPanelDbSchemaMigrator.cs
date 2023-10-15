using System.Threading.Tasks;

namespace ShopNServer.AdminPanel.Data;

public interface IAdminPanelDbSchemaMigrator
{
    Task MigrateAsync();
}
