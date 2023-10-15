using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace ShopNServer.AdminPanel.Web.Pages;

public class IndexModel : AdminPanelPageModel
{
    public void OnGet()
    {

    }

    public async Task OnPostLoginAsync()
    {
        await HttpContext.ChallengeAsync("oidc");
    }
}
