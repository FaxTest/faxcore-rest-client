using System.Collections.Generic;
using System.Threading.Tasks;
using FaxCoreRestClient.Models;
using FaxCoreRestClient.Models.Request;
using FaxCoreRestClient.Models.Response;

namespace FaxCoreRestClient.Client
{
    public partial class FaxClient : IFaxClient
    {
        /// <summary>
        ///     Approves or rejects a message (/api/message/approval)
        /// </summary>
        /// <param name="messageId">The message Id</param>
        /// <param name="approve">Approve (True) or Reject (False) </param>
        /// <param name="notes">Notes to include with the approval response</param>
        /// <returns></returns>
        public async Task<BooleanResponse> ApproveMessage(string messageId, bool approve, string notes)
        {
            return await _client.Put<BooleanResponse, object>("/api/message/approve", new
            {
                messageID = messageId,
                approve,
                notes
            });
        }

        /// <summary>
        ///     Assign inbound or outbound faxes to any users within the same domain
        ///     (/api/messages/assign)
        /// </summary>
        /// <param name="messageId">The message Id to be assigned</param>
        /// <param name="ownerId">The user Id of the user that the message belongs to</param>
        /// <param name="userList">A list of usernames to assign the fax to</param>
        /// <returns></returns>
        public async Task<Response<string>> AssignMessage(string messageId, string ownerId, IList<string> userList)
        {
            return await _client.Put<Response<string>, object>("/api/messages/assign", new
            {
                messageID = messageId,
                owner = ownerId,
                usernames = userList
            });
        }

        /// <summary>
        ///     Cancel a message that currently is in progress (/api/messages/cancel)
        /// </summary>
        /// <param name="messageId">The message to be cancelled</param>
        /// <returns></returns>
        public async Task<Response<string>> CancelMessage(string messageId)
        {
            return await _client.Put<Response<string>, object>("/api/messages/cancel", new
            {
                messageID = messageId
            });
        }

        /// <summary>
        ///     Send a message on behalf of another user (/api/messages/delegate)
        /// </summary>
        /// <param name="request">The message information with delegation <see cref="DelegationRequest" /></param>
        /// <returns>Delegation response <see cref="Response{T}" /><seealso cref="DelegationResponse" /></returns>
        public async Task<Response<DelegationResponse>> DelegateMessage(DelegationRequest request)
        {
            return await _client.Post<Response<DelegationResponse>, DelegationRequest>("/api/messages/delegate",
                request);
        }

        /// <summary>
        ///     Delete messages belong to authenticated user. Only able to delete own messages. For SystemAdmin, able to delete all
        ///     messages. Delete one or many messages (/api/message/delete)
        /// </summary>
        /// <param name="messageId"></param>
        /// <returns>
        ///     A response object with a list of message responses <see cref="Response{T}" />
        ///     <seealso cref="MessageResponseList" /> <seealso cref="MessageResponse" />
        /// </returns>
        public async Task<Response<MessageResponseList>> DeleteMessage(IList<string> messageId)
        {
            return await _client.Delete<Response<MessageResponseList>, object>("/api/message/delete",
                new { messageID = messageId });
        }

        /// <summary>
        ///     Retrieve delete status for a specific message. Roles segregation applies. (/api/message/delete_state)
        /// </summary>
        /// <param name="messageId">The ID of the message to check the delete status</param>
        /// <returns>
        ///     A response object that contains the deleted status <see cref="Response{T}" /> (T =
        ///     <see cref="DeletedStatusResponse" />)
        /// </returns>
        public async Task<Response<DeletedStatusResponse>> DeleteMessageStatus(string messageId)
        {
            return await _client.Post<Response<DeletedStatusResponse>, object>("/api/message/delete_state",
                new { messageID = messageId });
        }

        /// <summary>
        ///     Retrieve message details belong to auth user. SystemAdmin and DomainAdmin role able to access messages according to
        ///     standard role segregation.
        ///     (/api/message/details)
        /// </summary>
        /// <param name="messageId">The Message Id for the message to retrieve details</param>
        /// <returns>A response with the message details <see cref="Response{T}" /> (T = <see cref="Message" />)</returns>
        public async Task<Response<Message>> GetMessageDetails(string messageId)
        {
            return await _client.Post<Response<Message>, object>("/api/message/details",
                new { messageID = messageId });
        }

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
        public async Task<string> DownloadMessage(DownloadMessageRequest downloadParameters)
        {
            return await _client.Post<string, DownloadMessageRequest>("/api/message/download", downloadParameters);
        }

        /// <summary>
        ///     Mark the specified message as downloaded.
        ///     (/api/message/downloaded)
        /// </summary>
        /// <param name="messageId">The Unique ID of the message to mark as downloaded</param>
        /// <returns>
        ///     A response object with a string value indicating the message was marked downloaded <see cref="Response{T}" />
        ///     (T = <see cref="string" />)
        /// </returns>
        public async Task<Response<string>> MarkMessageAsDownloaded(string messageId)
        {
            return await _client.Post<Response<string>, object>("/api/message/downloaded",
                new { messageID = messageId });
        }

        /// <summary>
        ///     Retrieve list of folders belong to user. This will include private folder but not delegation. Role and domain
        ///     segregation applies.
        /// </summary>
        /// <returns>
        ///     A response with a list of Folders<see cref="Response{T}" /> (T = <see cref="List{T}" /> (T =
        ///     <see cref="FolderResponse" />))
        /// </returns>
        public async Task<Response<IList<FolderResponse>>> GetMessageFolders()
        {
            return await _client.Post<Response<IList<FolderResponse>>, object>("/api/message/folders", new { });
        }

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
        public async Task<Response<string>> ForwardMessageToUsers(string messageId, IList<string> userList)
        {
            return await _client.Post<Response<string>, object>("api/message/forward", new
            {
                messageID = messageId,
                usernames = userList
            });
        }

        /// <summary>
        ///     Retrieve user's message list from specified folder.
        /// </summary>
        /// <param name="messagesRequest">The Message List Request Object <see cref="FolderListMessagesRequest" /></param>
        /// <returns>A paged response of Messages <see cref="PagedResponse{T}" /> (T=<see cref="MessageListResponse" />)</returns>
        public async Task<PagedResponse<MessageListResponse>> GetMessageList(FolderListMessagesRequest messagesRequest)
        {
            return await _client.Post<PagedResponse<MessageListResponse>, FolderListMessagesRequest>(
                "/api/message/list",
                messagesRequest);
        }

        /// <summary>
        ///     ove existing message from one folder to another, include personal folder. The move only happen within user's
        ///     account, does not support cross user account.
        ///     (api/message/move)
        /// </summary>
        /// <param name="messageId">The unique id of the message to move</param>
        /// <param name="folderName">The folder name to move the message to</param>
        /// <returns>A response with a status string <see cref="Response{T}" /> (T=<see cref="string" />)</returns>
        public async Task<Response<string>> MoveMessageToFolder(string messageId, string folderName)
        {
            return await _client.Post<Response<string>, object>("/api/message/move", new
            {
                messageID = messageId,
                folder = folderName
            });
        }

        /// <summary>
        ///     Mark specific message read status to read or unread. This is a simple message flag set.
        ///     (api/message/read)
        /// </summary>
        /// <param name="messageId">The unique id of the message to move</param>
        /// <param name="read">Set the read status to Read (True) or Unread (False)</param>
        /// <returns>A response with a status string <see cref="Response{T}" /> (T=<see cref="string" />)</returns>
        public async Task<Response<string>> ToggleMessageRead(string messageId, bool read)
        {
            return await _client.Post<Response<string>, object>("/api/message/read", new
            {
                messageID = messageId,
                isRead = read
            });
        }

        /// <summary>
        ///     Retrieve message read status. This is a simple message read flag retrieval.
        /// </summary>
        /// <param name="messageId">The unique id of the message to move</param>
        /// <returns>A response with the read status <see cref="Response{T}" /> (T=<see cref="ReadStatusResponse" />)</returns>
        public async Task<Response<ReadStatusResponse>> GetMessageReadStatus(string messageId)
        {
            return await _client.Post<Response<ReadStatusResponse>, object>("/api/message/read_state",
                new { messageID = messageId });
        }

        /// <summary>
        ///     Set existing message with failed status to resend (ie, reattempt.). Only valid for own messages.
        ///     (api/message/retry)
        /// </summary>
        /// <param name="messageId">The unique ID of the message to retry</param>
        /// <returns>A response with a confirmation string <see cref="Response{T}" /> (T=<see cref="string" />)</returns>
        public async Task<Response<string>> RetryMessage(string messageId)
        {
            return await _client.Post<Response<string>, object>("/api/message/retry", new { messageID = messageId });
        }

        /// <summary>
        ///     Search Messages within the domain.
        /// </summary>
        /// <param name="searchRequest">The Message Search parameters object <see cref="MessageSearchRequest" /> </param>
        /// <returns>
        ///     A paged response with a list of results <see cref="PagedResponse{T}" /> (T=<see cref="MessageSearchResults" />)
        /// </returns>
        public async Task<PagedResponse<MessageSearchResults>> SearchMessages(MessageSearchRequest searchRequest)
        {
            return await _client.Post<PagedResponse<MessageSearchResults>, MessageSearchRequest>("/api/message/search",
                searchRequest);
        }
    }
}