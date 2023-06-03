namespace FaxCoreRestClient.Client
{
    public interface IFaxClientFactory
    {
        FaxClient Create(string faxServerUrl, string clientId, string clientSecret);
    }
}