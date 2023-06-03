namespace FaxCoreRestClient.Client
{
    public class FaxClientFactory : IFaxClientFactory
    {
        public IFaxClient Create(string faxServerUrl, string clientId, string clientSecret)
        {
            return new FaxClient(faxServerUrl, clientId, clientSecret);
        }
    }
}