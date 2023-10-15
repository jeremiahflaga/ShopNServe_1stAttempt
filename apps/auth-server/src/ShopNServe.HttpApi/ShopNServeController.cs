using ShopNServe.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace ShopNServe;

public abstract class ShopNServeController : AbpControllerBase
{
    protected ShopNServeController()
    {
        LocalizationResource = typeof(ShopNServeResource);
    }
}
