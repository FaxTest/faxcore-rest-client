namespace FaxCore.Ev6.RestClient
{
    public interface IFaxClientFactory
    {
        IFaxClient Create(string faxServerUrl, string clientId, string clientSecret);
    }
}