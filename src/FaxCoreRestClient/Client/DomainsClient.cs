using System.Threading.Tasks;
using FaxCoreRestClient.Models.Request;
using FaxCoreRestClient.Models.Response;

namespace FaxCoreRestClient.Client
{
    public partial class FaxClient
    {
        /// <summary>
        ///     Returns a list of domains that the current user has access to.
        /// </summary>
        /// <returns><see cref="Response{T}" /> (T = <see cref="string" />)</returns>
        public async Task<Response<string>> GetDomains()
        {
            return await _client.Get<Response<string>>("/api/domains");
        }

        /// <summary>
        ///     Creates a new domain.
        /// </summary>
        /// <param name="createRequest">
        ///     <see cref="DomainCreateRequest" />
        /// </param>
        /// <returns><see cref="Response{T}" /> (T = <see cref="string" />)</returns>
        public async Task<Response<string>> CreateDomain(DomainCreateRequest createRequest)
        {
            return await _client.Post<Response<string>, DomainCreateRequest>("/api/domains", createRequest);
        }
    }
}