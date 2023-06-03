namespace FaxCoreRestClient.Client
{
    /// <summary>
    ///     Rest Client for FaxCore
    /// </summary>
    public partial class FaxClient : IFaxClient
    {
        private readonly FaxCoreBaseClient _client;

        /// <summary>
        ///     Creates a new instance of the Fax Core Client. This client uses the client-credentials flow and
        ///     requires that a client id and client secret be provided.
        /// </summary>
        /// <param name="faxServerUrl">This is the URL to your FaxCore server</param>
        /// <param name="clientId">The ClientId of the user that will authenticate with the API</param>
        /// <param name="clientSecret">The client secret for the user that will authenticate with the API</param>
        public FaxClient(string faxServerUrl, string clientId, string clientSecret)

        {
            _client = new FaxCoreBaseClient(faxServerUrl, clientId, clientSecret);
        }
    }
}