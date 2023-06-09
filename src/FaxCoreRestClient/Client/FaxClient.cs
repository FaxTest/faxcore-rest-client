using System.Threading.Tasks;
using FaxCoreRestClient.Models.Response;

namespace FaxCoreRestClient.Client
{
    /// <summary>
    ///     Rest Client for FaxCore
    /// </summary>
    public partial class FaxClient
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

        /// <summary>
        ///     Upload files to retrieve encrypted file name to pass when creating a new message.
        /// </summary>
        /// <param name="filePath">The file path to the file being uploaded</param>
        /// <returns>
        ///     The response object with the newly created file details <see cref="Response{T}" /> (T =
        ///     <see cref="UploadResponse" />)
        /// </returns>
        public async Task<Response<UploadResponse>> UploadFile(string filePath)
        {
            return await _client.PostFile<Response<UploadResponse>>("/api/upload", filePath);
        }

        /// <summary>
        ///     Lists the current users cover page items
        /// </summary>
        /// <returns><see cref="Response{T}" />(T = <see cref="CoverPageItemResponse" /></returns>
        public async Task<Response<CoverPageItemResponse>> GetCoverPageItems()
        {
            return await _client.Get<Response<CoverPageItemResponse>>("/api/coverpages");
        }
    }
}