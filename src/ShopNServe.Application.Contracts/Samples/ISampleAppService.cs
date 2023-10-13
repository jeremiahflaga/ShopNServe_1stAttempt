using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace ShopNServe.Samples;

public interface ISampleAppService : IApplicationService
{
    Task<SampleDto> GetAsync();

    Task<SampleDto> GetAuthorizedAsync();
}
