using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace ShopNServe.Pages;

public class IndexModel : ShopNServePageModel
{
    public void OnGet()
    {

    }

    public async Task OnPostLoginAsync()
    {
        await HttpContext.ChallengeAsync("oidc");
    }
}
