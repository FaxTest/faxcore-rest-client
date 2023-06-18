using System.Threading.Tasks;
using FaxCore.Ev6.RestClient.Models.Request;
using FaxCore.Ev6.RestClient.Models.Response;

namespace FaxCore.Ev6.RestClient
{
    public partial class FaxClient : IFaxClient
    {
        /// <summary>
        ///     Returns a list of domains that the current user has access to.
        /// </summary>
        /// <returns><see cref="FaxCoreFaxCoreResponse{T}" /> (T = <see cref="string" />)</returns>
        public async Task<FaxCoreResponse<string>> GetDomains()
        {
            return await _client.Get<FaxCoreResponse<string>>("/api/domains");
        }

        /// <summary>
        ///     Creates a new domain.
        /// </summary>
        /// <param name="createRequest">
        ///     <see cref="DomainCreateRequest" />
        /// </param>
        /// <returns><see cref="FaxCoreFaxCoreResponse{T}" /> (T = <see cref="string" />)</returns>
        public async Task<FaxCoreResponse<string>> CreateDomain(DomainCreateRequest createRequest)
        {
            return await _client.Post<FaxCoreResponse<string>, DomainCreateRequest>("/api/domains", createRequest);
        }
    }
}