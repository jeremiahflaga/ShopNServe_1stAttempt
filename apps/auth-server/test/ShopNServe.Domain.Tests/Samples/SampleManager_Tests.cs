using System.Threading.Tasks;
using Xunit;

namespace ShopNServe.Samples;

public class SampleManager_Tests : ShopNServeDomainTestBase
{
    //private readonly SampleManager _sampleManager;

    public SampleManager_Tests()
    {
        //_sampleManager = GetRequiredService<SampleManager>();
    }

    [Fact]
    public Task Method1Async()
    {
        return Task.CompletedTask;
    }
}
