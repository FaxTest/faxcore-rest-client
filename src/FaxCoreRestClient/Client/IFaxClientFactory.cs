namespace FaxCoreRestClient.Client
{
    public interface IFaxClientFactory
    {
        IFaxClient Create(string faxServerUrl, string clientId, string clientSecret);
    }
}