using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace ShopNServe.PublicWeb.Web.Pages;

public class IndexModel : PublicWebPageModel
{
    public void OnGet()
    {

    }

    public async Task OnPostLoginAsync()
    {
        await HttpContext.ChallengeAsync("oidc");
    }
}
