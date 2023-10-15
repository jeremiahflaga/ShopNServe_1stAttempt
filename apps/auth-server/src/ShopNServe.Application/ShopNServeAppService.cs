using ShopNServe.Localization;
using Volo.Abp.Application.Services;

namespace ShopNServe;

public abstract class ShopNServeAppService : ApplicationService
{
    protected ShopNServeAppService()
    {
        LocalizationResource = typeof(ShopNServeResource);
        ObjectMapperContext = typeof(ShopNServeApplicationModule);
    }
}
