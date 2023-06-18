using System.Threading.Tasks;
using FaxCore.Ev6.RestClient.Models.Request;
using FaxCore.Ev6.RestClient.Models.Response;

namespace FaxCore.Ev6.RestClient
{
    public partial class FaxClient : IFaxClient
    {
        /// <summary>
        ///     Delete an Inbound Routing Rule
        ///     (DELETE /api/routes/delete)
        /// </summary>
        /// <param name="routeId">The unique ID of the route to be deleted</param>
        /// <returns><see cref="FaxCoreFaxCoreResponse{T}" /> (T=<see cref="string" />)</returns>
        public async Task<FaxCoreResponse<string>> DeleteRoutingRule(string routeId)
        {
            return await _client.Post<FaxCoreResponse<string>, object>("/api/routes/delete", new { routeID = routeId });
        }

        /// <summary>
        ///     Disable an Inbound Routing Rule
        ///     (POST /api/routes/disable)
        /// </summary>
        /// <param name="routeId">The unique ID of the route to be disabled</param>
        /// <returns><see cref="FaxCoreFaxCoreResponse{T}" /> (T=<see cref="string" />)</returns>
        public async Task<FaxCoreResponse<string>> DisableRoutingRule(string routeId)
        {
            return await _client.Post<FaxCoreResponse<string>, object>("/api/routes/disable", new { routeID = routeId });
        }

        /// <summary>
        ///     Enable an Inbound Routing Rule
        ///     (POST /api/routes/enable)
        /// </summary>
        /// <param name="routeId">The unique ID of the route to be enabled</param>
        /// <returns><see cref="FaxCoreFaxCoreResponse{T}" /> (T=<see cref="string" />)</returns>
        public async Task<FaxCoreResponse<string>> EnableRoutingRule(string routeId)
        {
            return await _client.Post<FaxCoreResponse<string>, object>("/api/routes/enable", new { routeID = routeId });
        }

        /// <summary>
        ///     Create a new Inbound Routing Rule
        ///     (POST /api/routes/inbound)
        /// </summary>
        /// <param name="createRequest">
        ///     <see cref="RouteCreateRequest" />
        /// </param>
        /// <returns><see cref="FaxCoreFaxCoreResponse{T}" /> (T = <see cref="string" />)</returns>
        public async Task<FaxCoreResponse<string>> CreateRoutingRule(RouteCreateRequest createRequest)
        {
            return await _client.Post<FaxCoreResponse<string>, RouteCreateRequest>("/api/routes/inbound", createRequest);
        }

        /// <summary>
        ///     Search for inbound routes with user input
        ///     (POST /api/routes/search)
        /// </summary>
        /// <param name="searchCriteria"></param>
        /// <returns><see cref="PagedResponse{T}" /> (T = <see cref="RouteSearchResponse" />)</returns>
        public async Task<PagedData<RouteSearchResponse>> SearchRoutingRules(string searchCriteria)
        {
            return await _client.Post<PagedData<RouteSearchResponse>, object>("/api/routes/search",
                new { searchCriteria });
        }
    }
}