using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace FaxCore.Ev6.RestClient.Models.Response
{
    /// <summary>
    ///     FaxCoreResponse Data for /api/messages/create
    /// </summary>
    public class SendMessageResponse
    {
        /// <summary>
        ///     The Id of the response message
        /// </summary>
        [DataMember(Name = "id")]
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        ///     The message number for the newly created message
        /// </summary>
        [DataMember(Name = "messageNo")]
        [JsonPropertyName("messageNo")]
        public int MessageNo { get; set; }

        /// <summary>
        ///     The unique message identifier
        /// </summary>
        [DataMember(Name = "messageID")]
        [JsonPropertyName("messageID")]
        public string MessageId { get; set; }
    }
}