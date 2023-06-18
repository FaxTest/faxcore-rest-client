using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace FaxCore.Ev6.RestClient.Models.Response
{
    public class BooleanResponse
    {
        /// <summary>
        ///     Gets or Sets the FaxCoreResponse Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        ///     Gets or Sets the FaxCoreResponse Message
        /// </summary>
        [DataMember(Name = "message", EmitDefaultValue = false)]
        [JsonPropertyName("message")]
        public string Message { get; set; }

        /// <summary>
        ///     Gets or Sets the FaxCoreResponse Data
        /// </summary>
        [DataMember(Name = "data", EmitDefaultValue = false)]
        [JsonPropertyName("data")]
        public bool Data { get; set; }
    }
}