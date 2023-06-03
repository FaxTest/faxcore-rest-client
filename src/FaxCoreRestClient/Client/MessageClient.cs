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
    }
}