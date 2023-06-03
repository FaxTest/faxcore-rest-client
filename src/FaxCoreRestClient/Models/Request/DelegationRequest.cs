using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace FaxCoreRestClient.Models.Request
{
    public class DelegationRequest
    {
        [DataMember(Name = "message")]
        [JsonPropertyName("message")]
        public DelegationMessage Message { get; set; }
    }
}