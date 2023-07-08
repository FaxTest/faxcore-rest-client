using FaxCore.Ev6.RestClient;

namespace FaxCore.Ev6.Test.Net7.Client;

public class FaxClientFactoryTests
{
    private IFaxClientFactory _clientFactory;
    private readonly string _blank = "";
    private readonly string _url = "https://example.com";
    private readonly string _key = "abc123";
    private readonly string _secret = "def456";

    [SetUp]
    public void Setup()
    {
        _clientFactory = new FaxClientFactory();
    }

    [Test]
    public void ShouldThrowErrorWhenMisconfigured()
    {
        Assert.Throws<ArgumentException>(() =>
        {
            _clientFactory.Create(_blank, _key, _secret);
        });

        Assert.Throws<ArgumentException>(() =>
        {
            _clientFactory.Create(_url, _blank, _key);
        });

        Assert.Throws<ArgumentException>(() =>
        {
            _clientFactory.Create(_blank, _key, _secret);
        });
    }

    [Test]
    public void ShouldReturnFaxClientWhenConfigured()
    {
        var client = _clientFactory.Create(_url, _key, _secret);

        Assert.IsInstanceOf<FaxClient>(client);
    }
}
