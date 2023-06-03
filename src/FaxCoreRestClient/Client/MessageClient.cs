using System.Collections.Generic;
using System.Threading.Tasks;
using FaxCoreRestClient.Models.Request;
using FaxCoreRestClient.Models.Response;

namespace FaxCoreRestClient.Client
{
    public partial class FaxClient
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
            return await Put<BooleanResponse, object>($"/api/messages/{messageId}/approve", new
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
            return await Put<Response<string>, object>("/api/messages/assign", new
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
            return await Put<Response<string>, object>("/api/messages/cancel", new
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
            return await Post<Response<DelegationResponse>, DelegationRequest>("/api/messages/delegate", request);
        }
    }
}