using System.Collections.Generic;
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
        /// <param name="request">
        ///     <see cref="UserConfigRequest" />
        /// </param>
        /// <returns></returns>
        public async Task<StatusOnlyResponse> UpdateUserConfig(UserConfigRequest request)
        {
            return await Put<StatusOnlyResponse, UserConfigRequest>("/api/users/config", request);
        }

        /// <summary>
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
        ///     <param name="users">The users to be deactivated <see cref="UserListRequest" /></param>
        ///     <returns>
        ///         <see cref="Response{T}" /> <seealso cref="string" />
        ///     </returns>
        /// </summary>
        public async Task<Response<string>> DeactivateUser(UserListRequest users)
        {
            return await Post<Response<string>, UserListRequest>("/api/users/deactivate", users);
        }


        /// <summary>
        ///     Get a List of Users for the specified domain.
        ///     ("/api/users/list")
        /// </summary>
        /// <param name="request">
        ///     <see cref="UserListRequest" />
        /// </param>
        /// <returns>A list of User Objects (<see cref="UserListItem" />)</returns>
        public async Task<Response<IEnumerable<UserListItem>>> UserList(UserListRequest request)
        {
            return await Post<Response<IEnumerable<UserListItem>>, UserListRequest>("/api/users/list",
                request);
        }

        /// <summary>
        ///     Delete the specified user
        ///     ("/api/users/delete")
        /// </summary>
        /// <param name="userToDelete">
        ///     <see cref="UserRequest" />
        /// </param>
        /// <returns>
        ///     <see cref="Response{T}" /> <seealso cref="string" />
        /// </returns>
        public async Task<Response<string>> DeleteUser(UserRequest userToDelete)
        {
            return await Delete<Response<string>, UserRequest>("/api/users/delete", userToDelete);
        }

        /// <summary>
        ///     Get the specified user's details
        ///     ("/api/users/details")
        /// </summary>
        /// <param name="user">
        ///     <see cref="UserRequest" />
        /// </param>
        /// <returns>
        ///     <see cref="Response{T}" /> <seealso cref="UserData" />
        /// </returns>
        public async Task<Response<UserData>> GetUserDetails(UserRequest user)
        {
            return await Post<Response<UserData>, UserRequest>("/api/users/details", user);
        }

        /// <summary>
        ///     Get the specified user's fax settings
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public async Task<Response<FaxSettings>> GetUserFaxSettings(UserRequest user)
        {
            return await Post<Response<FaxSettings>, UserRequest>("/api/users/faxsettings", user);
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