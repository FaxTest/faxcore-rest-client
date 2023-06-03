namespace FaxCoreRestClient.Client
{
    public class FaxClientFactory : IFaxClientFactory
    {
        public FaxClient Create(string faxServerUrl, string clientId, string clientSecret)
        {
            return new FaxClient(faxServerUrl, clientId, clientSecret);
        }
    }
}