using System.Collections.Generic;
using System.Threading.Tasks;
using FaxCoreRestClient.Models;
using FaxCoreRestClient.Models.Request;
using FaxCoreRestClient.Models.Response;

namespace FaxCoreRestClient.Client
{
    public interface IFaxClient
    {
        /// <summary>
        ///     Approves or rejects a message (/api/message/approval)
        ///     (/api/message/approval)
        /// </summary>
        /// <param name="messageId">The message Id</param>
        /// <param name="approve">Approve (True) or Reject (False) </param>
        /// <param name="notes">Notes to include with the approval response</param>
        /// <returns></returns>
        Task<BooleanResponse> ApproveMessage(string messageId, bool approve, string notes);

        /// <summary>
        ///     Assign inbound or outbound faxes to any users within the same domain
        ///     (/api/messages/assign)
        /// </summary>
        /// <param name="messageId">The message Id to be assigned</param>
        /// <param name="ownerId">The user Id of the user that the message belongs to</param>
        /// <param name="userList">A list of usernames to assign the fax to</param>
        /// <returns></returns>
        Task<Response<string>> AssignMessage(string messageId, string ownerId, IList<string> userList);

        /// <summary>
        ///     Cancel a message that currently is in progress (/api/messages/cancel)
        /// </summary>
        /// <param name="messageId">The message to be cancelled</param>
        /// <returns></returns>
        Task<Response<string>> CancelMessage(string messageId);

        /// <summary>
        ///     Send a message on behalf of another user (/api/messages/delegate)
        /// </summary>
        /// <param name="request">The message information with delegation <see cref="DelegationRequest" /></param>
        /// <returns>Delegation response <see cref="Response{T}" /><seealso cref="DelegationResponse" /></returns>
        Task<Response<DelegationResponse>> DelegateMessage(DelegationRequest request);

        /// <summary>
        ///     Delete messages belong to authenticated user. Only able to delete own messages. For SystemAdmin, able to delete all
        ///     messages. Delete one or many messages (/api/message/delete)
        /// </summary>
        /// <param name="messageId"></param>
        /// <returns>
        ///     A response object with a list of message responses <see cref="Response{T}" />
        ///     <seealso cref="MessageResponseList" /> <seealso cref="MessageResponse" />
        /// </returns>
        Task<Response<MessageResponseList>> DeleteMessage(IList<string> messageId);

        /// <summary>
        ///     Retrieve delete status for a specific message. Roles segregation applies. (/api/message/delete_state)
        /// </summary>
        /// <param name="messageId">The ID of the message to check the delete status</param>
        /// <returns>
        ///     A response object that contains the deleted status <see cref="Response{T}" /> (T =
        ///     <see cref="DeletedStatusResponse" />)
        /// </returns>
        Task<Response<DeletedStatusResponse>> DeleteMessageStatus(string messageId);

        /// <summary>
        ///     Retrieve message details belong to auth user. SystemAdmin and DomainAdmin role able to access messages according to
        ///     standard role segregation.
        ///     (/api/message/details)
        /// </summary>
        /// <param name="messageId">The Message Id for the message to retrieve details</param>
        /// <returns>A response with the message details <see cref="Response{T}" /> (T = <see cref="Message" />)</returns>
        Task<Response<Message>> GetMessageDetails(string messageId);

        /// <summary>
        ///     Download message based on filter values. This consolidate 4 different methods in ev5 into single entry. Delivery
        ///     ID(transaction id) in ev5 no longer relevant as transaction ID value only available from get message details.
        ///     (/api/message/download)
        /// </summary>
        /// <sample>
        ///     var fileDetails = _faxClient.DownloadMessage(new DownloadMessageRequest);
        ///     using (StreamWriter writer = new StreamWriter("C:\\temp\\test.pdf"))
        ///     writer.Write(fileDetails);
        ///     }
        /// </sample>
        /// <param name="downloadParameters">The download parameters <see cref="DownloadMessageRequest" /></param>
        /// <returns>Depending on the DownloadMessageRequest, the output stream should be application/pdf or image/tif as a string.</returns>
        Task<string> DownloadMessage(DownloadMessageRequest downloadParameters);

        /// <summary>
        ///     Mark the specified message as downloaded.
        ///     (/api/message/downloaded)
        /// </summary>
        /// <param name="messageId">The Unique ID of the message to mark as downloaded</param>
        /// <returns>
        ///     A response object with a string value indicating the message was marked downloaded <see cref="Response{T}" />
        ///     (T = <see cref="string" />)
        /// </returns>
        Task<Response<string>> MarkMessageAsDownloaded(string messageId);

        /// <summary>
        ///     Retrieve list of folders belong to user. This will include private folder but not delegation. Role and domain
        ///     segregation applies.
        /// </summary>
        /// <returns>
        ///     A response with a list of Folders<see cref="Response{T}" /> (T = <see cref="List{T}" /> (T =
        ///     <see cref="FolderResponse" />))
        /// </returns>
        Task<Response<IList<FolderResponse>>> GetMessageFolders();

        /// <summary>
        ///     Forward the specified message to a list of other users.
        ///     (/api/message/forward)
        /// </summary>
        /// <param name="messageId">The unique id of the message to forward</param>
        /// <param name="userList">A list of usernames to forward the message to</param>
        /// <returns>
        ///     A response with a string indicating the status of the forwarding. <see cref="Response{T}" /> (T =
        ///     <see cref="string" />)
        /// </returns>
        Task<Response<string>> ForwardMessageToUsers(string messageId, IList<string> userList);

        /// <summary>
        ///     Retrieve user's message list from specified folder.
        /// </summary>
        /// <param name="messagesRequest">The Message List Request Object <see cref="FolderListMessagesRequest" /></param>
        /// <returns>A paged response of Messages <see cref="PagedResponse{T}" /> (T=<see cref="MessageListResponse" />)</returns>
        Task<PagedResponse<MessageListItem>> GetMessageList(FolderListMessagesRequest messagesRequest);

        /// <summary>
        ///     ove existing message from one folder to another, include personal folder. The move only happen within user's
        ///     account, does not support cross user account.
        ///     (api/message/move)
        /// </summary>
        /// <param name="messageId">The unique id of the message to move</param>
        /// <param name="folderName">The folder name to move the message to</param>
        /// <returns>A response with a status string <see cref="Response{T}" /> (T=<see cref="string" />)</returns>
        Task<Response<string>> MoveMessageToFolder(string messageId, string folderName);

        /// <summary>
        ///     Mark specific message read status to read or unread. This is a simple message flag set.
        ///     (api/message/read)
        /// </summary>
        /// <param name="messageId">The unique id of the message to move</param>
        /// <param name="read">Set the read status to Read (True) or Unread (False)</param>
        /// <returns>A response with a status string <see cref="Response{T}" /> (T=<see cref="string" />)</returns>
        Task<Response<string>> ToggleMessageRead(string messageId, bool read);

        /// <summary>
        ///     Retrieve message read status. This is a simple message read flag retrieval.
        /// </summary>
        /// <param name="messageId">The unique id of the message to move</param>
        /// <returns>A response with the read status <see cref="Response{T}" /> (T=<see cref="ReadStatusResponse" />)</returns>
        Task<Response<ReadStatusResponse>> GetMessageReadStatus(string messageId);

        /// <summary>
        ///     Set existing message with failed status to resend (ie, reattempt.). Only valid for own messages.
        ///     (api/message/retry)
        /// </summary>
        /// <param name="messageId">The unique ID of the message to retry</param>
        /// <returns>A response with a confirmation string <see cref="Response{T}" /> (T=<see cref="string" />)</returns>
        Task<Response<string>> RetryMessage(string messageId);

        /// <summary>
        ///     Search Messages within the domain.
        /// </summary>
        /// <param name="searchRequest">The Message Search parameters object <see cref="MessageSearchRequest" /> </param>
        /// <returns>
        ///     A paged response with a list of results <see cref="PagedResponse{T}" /> (T=<see cref="MessageSearchResults" />)
        /// </returns>
        Task<PagedResponse<MessageSearchResults>> SearchMessages(MessageSearchRequest searchRequest);

        /// <summary>
        ///     NOTICE: YOU MUST CALL FaxClient.UploadFile() FIRST TO GET THE FILE ID
        ///     Create new message (fax and email). The usual user permissions applies.
        /// </summary>
        /// <param name="messageRequest">
        ///     The Message Request Object <see cref="SendMessageRequest{T}" /> (T=
        ///     <see cref="MessageRecipient" />)
        /// </param>
        /// <returns>
        ///     A response with a the details of the created message <see cref="Response{T}" /> (T=
        ///     <see cref="SendMessageResponse" />)
        /// </returns>
        Task<Response<SendMessageResponse>> SendMessage(
            SendMessageRequest<MessageRecipient> messageRequest);

        /// <summary>
        ///     NOTICE: YOU MUST CALL FaxClient.UploadFile() FIRST TO GET THE FILE ID
        ///     Create new message (fax and email) to an internal user. The usual user permissions applies.
        /// </summary>
        /// <param name="messageRequest">
        ///     The Message Request Object <see cref="SendMessageRequest{T}" /> (T =
        ///     <see cref="InternalRecipient" />)
        /// </param>
        /// <returns>
        ///     A response with a the details of the created message <see cref="Response{T}" /> (T=
        ///     <see cref="SendMessageResponse" />)
        /// </returns>
        Task<Response<SendMessageResponse>> SendMessageInternal(
            SendMessageRequest<InternalRecipient> messageRequest);

        /// <summary>
        ///     Get the status of a message
        ///     (api/message/status)
        /// </summary>
        /// <param name="messageId"></param>
        /// <returns>A response object with a Status response <see cref="Response{T}" /> (T=<see cref="MessageStatusResponse" />)</returns>
        Task<Response<MessageStatusResponse>> GetMessageStatus(string messageId);

        /// <summary>
        ///     Update the subject of a message
        ///     (api/message/subject)
        /// </summary>
        /// <param name="messageId"></param>
        /// <param name="subjectString"></param>
        /// <returns>Returns a response object with a boolean status <see cref="BooleanResponse" /></returns>
        Task<Response<BooleanResponse>> UpdateMessageSubject(string messageId, string subjectString);

        /// <summary>
        ///     Update the tracking information on a message.
        ///     (api/message/tracking)
        /// </summary>
        /// <param name="messageId"></param>
        /// <param name="trackingValue"></param>
        /// <param name="trackingId"></param>
        /// <returns>Returns a response object with a string result <see cref="Response{T}" /> (T=<see cref="string" />)</returns>
        Task<Response<string>> UpdateMessageTracking(string messageId, string trackingValue,
            int trackingId = 0);

        /// <summary>
        ///     Returns the tracking information for a message
        ///     (api/message/tracking)
        /// </summary>
        /// <param name="messageId"></param>
        /// <returns>
        ///     A response object with the tracking details for the message <see cref="Response{T}" />(T =
        ///     <see cref="TrackingResponse" />)
        /// </returns>
        Task<Response<TrackingResponse>> GetMessageTracking(string messageId);

        /// <summary>
        ///     Sends a list of users to be activated
        ///     ("/api/users/create")
        /// </summary>
        /// <param name="users">A list of users to be activated</param>
        /// <returns>
        ///     <see cref="StatusOnlyResponse" />
        /// </returns>
        Task<StatusOnlyResponse> ActivateUsers(IEnumerable<string> users);

        /// <summary>
        ///     Updates the specified user's configuration
        ///     ("/api/users/config")
        /// </summary>
        /// <param name="request">
        ///     <see cref="UserConfigRequest" />
        /// </param>
        /// <returns></returns>
        Task<StatusOnlyResponse> UpdateUserConfig(UserConfigRequest request);

        /// <summary>
        ///     Create new user in a specific domain. Only create in domain which user belong to.
        /// </summary>
        /// <param name="user">The CreateUserRequest for the user being created <see cref="CreateUserRequest" /></param>
        /// <returns>
        ///     The response with the newly created user's UserId <see cref="Response{T}" /> <seealso cref="UserListItem" />
        /// </returns>
        Task<Response<UserListItem>> CreateUser(CreateUserRequest user);

        /// <summary>
        ///     Deactivates the specified user(s)
        ///     ("/api/users/deactivate")
        ///     <param name="users">A list of users to be deactivated</param>
        ///     <returns>
        ///         <see cref="Response{T}" /> <seealso cref="string" />
        ///     </returns>
        /// </summary>
        Task<Response<string>> DeactivateUser(IEnumerable<string> users);

        /// <summary>
        ///     Get a List of Users for the specified domain.
        ///     ("/api/users/list")
        /// </summary>
        /// <param name="domainName">
        ///     The domain to get the list of users from
        /// </param>
        /// <returns>A list of User Objects (<see cref="UserListItem" />)</returns>
        Task<Response<IEnumerable<UserListItem>>> UserList(string domainName);

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
        Task<Response<string>> DeleteUser(string userId);

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
        Task<Response<UserData>> GetUserDetails(string userId);

        /// <summary>
        ///     Get the specified user's fax settings
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        Task<Response<FaxSettings>> GetUserFaxSettings(string userId);

        /// <summary>
        ///     Move user to another domain
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="domainName"></param>
        /// <returns>
        ///     <see cref="Response{T}" /> <seealso cref="string" />
        /// </returns>
        Task<Response<string>> ChangeUserDomain(string userId, string domainName);

        /// <summary>
        ///     Update the logged in user's profile details
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<Response<string>> UpdateUser(UpdateUserDetails request);

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
        Task<PagedResponse<UserSearchResponse>> UserSearch(
            UserSearchRequest searchRequest);

        /// <summary>
        ///     Create an address book for the user that is authenticated.
        ///     (POST /api/addressbook)
        /// </summary>
        /// <param name="addressBook">The name of the address book to create</param>
        /// <returns>
        ///     A response with the an object containing the address book ID. <see cref="Response{T}" /> (T=
        ///     <see cref="AddressBookCreateResponse" />)
        /// </returns>
        Task<Response<AddressBookCreateResponse>> CreateAddressBook(string addressBook);

        /// <summary>
        ///     Delete specific address book from user account. Address book with existing contact will get exception.
        ///     (DELETE /api/addressbook)
        /// </summary>
        /// <param name="addressBookId"></param>
        /// <returns>A response object with a status string<see cref="Response{T}" /> (T=<see cref="string" />)</returns>
        Task<Response<string>> DeleteAddressBook(int addressBookId);

        /// <summary>
        ///     Get all address books for the user that is authenticated.
        ///     (POST /api/addressbook)
        /// </summary>
        /// <param name="paginationSettings"></param>
        /// <returns>A paged list of Address books <see cref="PagedResponse{T}" /> (T=<see cref="AddressBookListResponse" />)</returns>
        Task<PagedResponse<AddressBookListResponse>> GetAddressBooks(Pagination paginationSettings);

        /// <summary>
        ///     Create a contact for the user that is authenticated.
        ///     (POST /api/contact)
        /// </summary>
        /// <param name="contact">
        ///     <see cref="CreateContactRequest" />
        /// </param>
        /// <returns>
        ///     A response with the newly created contact ID. <see cref="Response{T}" /> (T=
        ///     <see cref="ContactCreationResponse" />)
        /// </returns>
        Task<Response<ContactCreationResponse>> CreateContact(CreateContactRequest contact);

        /// <summary>
        ///     Delete specific contact from user account.
        ///     (DELETE /api/contact)
        /// </summary>
        /// <param name="contactId"></param>
        /// <returns>A response with a status string <see cref="Response{T}" />(T=<see cref="string" />)</returns>
        Task<Response<string>> DeleteContact(int contactId);

        /// <summary>
        ///     Get all contacts for the user that is authenticated, based on the specified address book
        ///     (POST /api/contact/list)
        /// </summary>
        /// <param name="request">
        ///     <see cref="ContactListRequest" />
        /// </param>
        /// <returns><see cref="PagedResponse{T}" /> (T=<see cref="ContactListItemResponse" />)</returns>
        Task<PagedResponse<ContactListItemResponse>> ListContacts(ContactListRequest request);

        /// <summary>
        ///     Upload files to retrieve encrypted file name to pass when creating a new message.
        /// </summary>
        /// <param name="filePath">The file path to the file being uploaded</param>
        /// <returns>
        ///     The response object with the newly created file details <see cref="Response{T}" /> (T =
        ///     <see cref="UploadResponse" />)
        /// </returns>
        Task<Response<UploadResponse>> UploadFile(string filePath);

        /// <summary>
        ///     Lists the current users cover page items
        /// </summary>
        /// <returns><see cref="Response{T}" />(T = <see cref="CoverPageItemResponse" /></returns>
        Task<Response<CoverPageItemResponse>> GetCoverPageItems();

        /// <summary>
        ///     Delete an Inbound Routing Rule
        ///     (DELETE /api/routes/delete)
        /// </summary>
        /// <param name="routeId">The unique ID of the route to be deleted</param>
        /// <returns><see cref="Response{T}" /> (T=<see cref="string" />)</returns>
        Task<Response<string>> DeleteRoutingRule(string routeId);

        /// <summary>
        ///     Disable an Inbound Routing Rule
        ///     (POST /api/routes/disable)
        /// </summary>
        /// <param name="routeId">The unique ID of the route to be disabled</param>
        /// <returns><see cref="Response{T}" /> (T=<see cref="string" />)</returns>
        Task<Response<string>> DisableRoutingRule(string routeId);

        /// <summary>
        ///     Enable an Inbound Routing Rule
        ///     (POST /api/routes/enable)
        /// </summary>
        /// <param name="routeId">The unique ID of the route to be enabled</param>
        /// <returns><see cref="Response{T}" /> (T=<see cref="string" />)</returns>
        Task<Response<string>> EnableRoutingRule(string routeId);

        /// <summary>
        ///     Create a new Inbound Routing Rule
        ///     (POST /api/routes/inbound)
        /// </summary>
        /// <param name="createRequest">
        ///     <see cref="RouteCreateRequest" />
        /// </param>
        /// <returns><see cref="Response{T}" /> (T = <see cref="string" />)</returns>
        Task<Response<string>> CreateRoutingRule(RouteCreateRequest createRequest);

        /// <summary>
        ///     Search for inbound routes with user input
        ///     (POST /api/routes/search)
        /// </summary>
        /// <param name="searchCriteria"></param>
        /// <returns><see cref="PagedResponse{T}" /> (T = <see cref="RouteSearchResponse" />)</returns>
        Task<PagedData<RouteSearchResponse>> SearchRoutingRules(string searchCriteria);

        /// <summary>
        ///     Returns a list of domains that the current user has access to.
        /// </summary>
        /// <returns><see cref="Response{T}" /> (T = <see cref="string" />)</returns>
        Task<Response<string>> GetDomains();

        /// <summary>
        ///     Creates a new domain.
        /// </summary>
        /// <param name="createRequest">
        ///     <see cref="DomainCreateRequest" />
        /// </param>
        /// <returns><see cref="Response{T}" /> (T = <see cref="string" />)</returns>
        Task<Response<string>> CreateDomain(DomainCreateRequest createRequest);
    }
}