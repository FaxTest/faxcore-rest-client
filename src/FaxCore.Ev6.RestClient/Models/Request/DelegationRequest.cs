using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace FaxCore.Ev6.RestClient.Models.Request
{
    public class DelegationRequest
    {
        [DataMember(Name = "message")]
        [JsonPropertyName("message")]
        public DelegationMessage Message { get; set; }
    }
}