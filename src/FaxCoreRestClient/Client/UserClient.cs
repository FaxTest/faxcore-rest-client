using System.Threading.Tasks;
using FaxCoreRestClient.Models.Request;
using FaxCoreRestClient.Models.Response;

namespace FaxCoreRestClient.Client
{
    /// <summary>
    ///     Rest Client for FaxCore User Routes
    /// </summary>
    public class UserClient : FaxCoreBaseClient
    {
        public UserClient(string baseUrl, string clientId, string clientSecret) : base(baseUrl, clientId, clientSecret)
        {
        }

        /// <summary>
        ///     Sends a list of users to be activated
        ///     ("/api/users/create")
        /// </summary>
        /// <param name="request">A list of users to be activated <see cref="UserActivationRequest" /></param>
        /// <returns>
        ///     <see cref="StatusOnlyResponse" />
        /// </returns>
        public async Task<StatusOnlyResponse> ActivateUsers(UserActivationRequest request)
        {
            return await Post<StatusOnlyResponse, UserActivationRequest>("/api/users/create", request);
        }

        /// <summary>
        ///     Updates the specified user's configuration
        ///     ("/api/users/config")
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<StatusOnlyResponse> UpdateUserConfig(UserConfigRequest request)
        {
            return await Post<StatusOnlyResponse, UserConfigRequest>("/api/users/config", request);
        }

        /// <summary>
        ///     Get a List of Users for the specified domain.
        ///     ("/api/users/list")
        /// </summary>
        /// <param name="request">
        ///     <see cref="UserListRequest" />
        /// </param>
        /// <returns>A list of User Objects (<see cref="UserListItem" />)</returns>
        public async Task<CollectionResponse<UserListItem>> UserList(UserListRequest request)
        {
            return await Post<CollectionResponse<UserListItem>, UserListRequest>("/api/users/list", request);
        }

        /// <summary>
        ///     Sends a confirmation email to the specified user
        ///     ("/api/users/sendConfirmEmail")
        /// </summary>
        /// <param name="confirmEmailRequest">
        ///     <see cref="ConfirmEmailRequest" />
        /// </param>
        /// <returns>A status report of the attempt to send the email <see cref="StatusOnlyResponse" /></returns>
        public async Task<StatusOnlyResponse> SendConfirmEmail(ConfirmEmailRequest confirmEmailRequest)
        {
            return await Post<StatusOnlyResponse, ConfirmEmailRequest>("/api/users/sendConfirmEmail",
                confirmEmailRequest);
        }

        /// <summary>
        ///     Sends the specified custom email template to the specified user
        ///     ("/api/users/sendCustomEmail")
        /// </summary>
        /// <param name="customEmailRequest">
        ///     <see cref="CustomEmailRequest" />
        /// </param>
        /// <returns>
        ///     <see cref="StatusOnlyResponse" />
        /// </returns>
        public async Task<StatusOnlyResponse> SendCustomEmail(CustomEmailRequest customEmailRequest)
        {
            return await Post<StatusOnlyResponse, CustomEmailRequest>("/api/users/sendCustomEmail", customEmailRequest);
        }

        /// <summary>
        ///     Search for users
        ///     ("/api/users/search")
        /// </summary>
        /// <param name="searchRequest">
        ///     <see cref="UserSearchRequest" />
        /// </param>
        /// <returns>
        ///     A PagedResponse of UserSearchResponse Objects
        ///     <see cref="PagedResponse{T}" /> <see cref="UserSearchResponse" />
        /// </returns>
        public async Task<PagedResponse<UserSearchResponse>> UserSearch(
            UserSearchRequest searchRequest)
        {
            return await Post<PagedResponse<UserSearchResponse>, UserSearchRequest>("/api/users/search",
                searchRequest);
        }
    }
}