using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace FaxCore.Ev6.RestClient.Models.Response
{
    public class DelegationResponse
    {
        [DataMember(Name = "id")]
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [DataMember(Name = "message")]
        [JsonPropertyName("message")]
        public long MessageNo { get; set; }

        [DataMember(Name = "messageId")]
        [JsonPropertyName("messageId")]
        public string MessageId { get; set; }
    }
}