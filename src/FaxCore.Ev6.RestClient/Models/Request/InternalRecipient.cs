using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace FaxCore.Ev6.RestClient.Models.Request
{
    public class InternalRecipient
    {
        /// <summary>
        ///     The username to deliver the message to
        /// </summary>
        [DataMember(Name = "userName")]
        [JsonPropertyName("userName")]
        public string UserName { get; set; }
    }
}