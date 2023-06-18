using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FaxCore.Ev6.RestClient.Models.Request;
using FaxCore.Ev6.RestClient.Models.Response;

namespace FaxCore.Ev6.RestClient
{
    public partial class FaxClient : IFaxClient
    {
        /// <summary>
        ///     Sends a list of users to be activated
        ///     ("/api/users/create")
        /// </summary>
        /// <param name="users">A list of users to be activated</param>
        /// <returns>
        ///     <see cref="StatusOnlyResponse" />
        /// </returns>
        public async Task<StatusOnlyResponse> ActivateUsers(IEnumerable<string> users)
        {
            return await _client.Post<StatusOnlyResponse, object>("/api/users/create",
                new { userIDList = users.ToArray() });
        }

        /// <summary>
        ///     Updates the specified user's configuration
        ///     ("/api/users/config")
        /// </summary>
        /// <param name="request">
        ///     <see cref="UserConfigRequest" />
        /// </param>
        /// <returns></returns>
        public async Task<StatusOnlyResponse> UpdateUserConfig(UserConfigRequest request)
        {
            return await _client.Put<StatusOnlyResponse, UserConfigRequest>("/api/users/config", request);
        }

        /// <summary>
        ///     Create new user in a specific domain. Only create in domain which user belong to.
        /// </summary>
        /// <param name="user">The CreateUserRequest for the user being created <see cref="CreateUserRequest" /></param>
        /// <returns>
        ///     The response with the newly created user's UserId <see cref="FaxCoreFaxCoreResponse{T}" /> <seealso cref="UserListItem" />
        /// </returns>
        public async Task<FaxCoreResponse<UserListItem>> CreateUser(CreateUserRequest user)
        {
            return await _client.Post<FaxCoreResponse<UserListItem>, CreateUserRequest>("/api/users/create", user);
        }

        /// <summary>
        ///     Deactivates the specified user(s)
        ///     ("/api/users/deactivate")
        ///     <param name="users">A list of users to be deactivated</param>
        ///     <returns>
        ///         <see cref="FaxCoreFaxCoreResponse{T}" /> <seealso cref="string" />
        ///     </returns>
        /// </summary>
        public async Task<FaxCoreResponse<string>> DeactivateUser(IEnumerable<string> users)
        {
            var requestData = new { userIDList = users.ToArray() };
            return await _client.Post<FaxCoreResponse<string>, object>("/api/users/deactivate", requestData);
        }


        /// <summary>
        ///     Get a List of Users for the specified domain.
        ///     ("/api/users/list")
        /// </summary>
        /// <param name="domainName">
        ///     The domain to get the list of users from
        /// </param>
        /// <returns>A list of User Objects (<see cref="UserListItem" />)</returns>
        public async Task<FaxCoreResponse<IEnumerable<UserListItem>>> UserList(string domainName)
        {
            return await _client.Post<FaxCoreResponse<IEnumerable<UserListItem>>, object>("/api/users/list",
                new { domain = domainName });
        }

        /// <summary>
        ///     Delete the specified user
        ///     ("/api/users/delete")
        /// </summary>
        /// <param name="userId">
        ///     The user id of the user to be deleted
        /// </param>
        /// <returns>
        ///     <see cref="FaxCoreFaxCoreResponse{T}" /> <seealso cref="string" />
        /// </returns>
        public async Task<FaxCoreResponse<string>> DeleteUser(string userId)
        {
            return await _client.Delete<FaxCoreResponse<string>, object>("/api/users/delete", new { user = userId });
        }

        /// <summary>
        ///     Get the specified user's details
        ///     ("/api/users/details")
        /// </summary>
        /// <param name="userId">
        ///     The userId of the user to get the details for
        /// </param>
        /// <returns>
        ///     <see cref="FaxCoreFaxCoreResponse{T}" /> <seealso cref="UserData" />
        /// </returns>
        public async Task<FaxCoreResponse<UserData>> GetUserDetails(string userId)
        {
            return await _client.Post<FaxCoreResponse<UserData>, object>("/api/users/details", new { user = userId });
        }

        /// <summary>
        ///     Get the specified user's fax settings
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public async Task<FaxCoreResponse<FaxSettings>> GetUserFaxSettings(string userId)
        {
            return await _client.Post<FaxCoreResponse<FaxSettings>, object>("/api/users/faxsettings", new { user = userId });
        }

        /// <summary>
        ///     Move user to another domain
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="domainName"></param>
        /// <returns>
        ///     <see cref="FaxCoreFaxCoreResponse{T}" /> <seealso cref="string" />
        /// </returns>
        public async Task<FaxCoreResponse<string>> ChangeUserDomain(string userId, string domainName)
        {
            var request = new
            {
                UserId = userId,
                DomainName = domainName
            };

            return await _client.Put<FaxCoreResponse<string>, object>("/api/users/domain", request);
        }

        /// <summary>
        ///     Update the logged in user's profile details
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<FaxCoreResponse<string>> UpdateUser(UpdateUserDetails request)
        {
            return await _client.Put<FaxCoreResponse<string>, UpdateUserDetails>("/api/users/faxsettings", request);
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
            return await _client.Post<PagedResponse<UserSearchResponse>, UserSearchRequest>("/api/users/search",
                searchRequest);
        }
    }
}