using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FaxCoreRestClient.Models.Request;
using FaxCoreRestClient.Models.Response;

namespace FaxCoreRestClient.Client
{
    public partial class FaxClient
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
            return await Post<StatusOnlyResponse, object>("/api/users/create", new { userIDList = users.ToArray() });
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
            return await Put<StatusOnlyResponse, UserConfigRequest>("/api/users/config", request);
        }

        /// <summary>
        ///     Create new user in a specific domain. Only create in domain which user belong to.
        /// </summary>
        /// <param name="user">The CreateUserRequest for the user being created <see cref="CreateUserRequest" /></param>
        /// <returns>
        ///     The response with the newly created user's UserId <see cref="Response{T}" /> <seealso cref="UserListItem" />
        /// </returns>
        public async Task<Response<UserListItem>> CreateUser(CreateUserRequest user)
        {
            return await Post<Response<UserListItem>, CreateUserRequest>("/api/users/create", user);
        }

        /// <summary>
        ///     Deactivates the specified user(s)
        ///     ("/api/users/deactivate")
        ///     <param name="users">A list of users to be deactivated</param>
        ///     <returns>
        ///         <see cref="Response{T}" /> <seealso cref="string" />
        ///     </returns>
        /// </summary>
        public async Task<Response<string>> DeactivateUser(IEnumerable<string> users)
        {
            var requestData = new { userIDList = users.ToArray() };
            return await Post<Response<string>, object>("/api/users/deactivate", requestData);
        }


        /// <summary>
        ///     Get a List of Users for the specified domain.
        ///     ("/api/users/list")
        /// </summary>
        /// <param name="domainName">
        ///     The domain to get the list of users from
        /// </param>
        /// <returns>A list of User Objects (<see cref="UserListItem" />)</returns>
        public async Task<Response<IEnumerable<UserListItem>>> UserList(string domainName)
        {
            return await Post<Response<IEnumerable<UserListItem>>, object>("/api/users/list",
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
        ///     <see cref="Response{T}" /> <seealso cref="string" />
        /// </returns>
        public async Task<Response<string>> DeleteUser(string userId)
        {
            return await Delete<Response<string>, object>("/api/users/delete", new { user = userId });
        }

        /// <summary>
        ///     Get the specified user's details
        ///     ("/api/users/details")
        /// </summary>
        /// <param name="userId">
        ///     The userId of the user to get the details for
        /// </param>
        /// <returns>
        ///     <see cref="Response{T}" /> <seealso cref="UserData" />
        /// </returns>
        public async Task<Response<UserData>> GetUserDetails(string userId)
        {
            return await Post<Response<UserData>, object>("/api/users/details", new { user = userId });
        }

        /// <summary>
        ///     Get the specified user's fax settings
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public async Task<Response<FaxSettings>> GetUserFaxSettings(string userId)
        {
            return await Post<Response<FaxSettings>, object>("/api/users/faxsettings", new { user = userId });
        }

        /// <summary>
        ///     Move user to another domain
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="domainName"></param>
        /// <returns>
        ///     <see cref="Response{T}" /> <seealso cref="string" />
        /// </returns>
        public async Task<Response<string>> ChangeUserDomain(string userId, string domainName)
        {
            var request = new
            {
                UserId = userId,
                DomainName = domainName
            };

            return await Put<Response<string>, object>("/api/users/domain", request);
        }

        /// <summary>
        ///     Update the logged in user's profile details
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<Response<string>> UpdateUser(UpdateUserDetails request)
        {
            return await Put<Response<string>, UpdateUserDetails>("/api/users/faxsettings", request);
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