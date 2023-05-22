using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace FaxCoreRestClient.Models.Response
{
    public class Response<T> where T : class
    {
        /// <summary>
        ///     Gets or Sets the Response Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        ///     Gets or Sets the Response Message
        /// </summary>
        [DataMember(Name = "message", EmitDefaultValue = false)]
        [JsonPropertyName("message")]
        public string Message { get; set; }

        /// <summary>
        ///     Gets or Sets the Response Data
        /// </summary>
        [DataMember(Name = "data", EmitDefaultValue = false)]
        [JsonPropertyName("data")]
        public T Data { get; set; }
    }
}