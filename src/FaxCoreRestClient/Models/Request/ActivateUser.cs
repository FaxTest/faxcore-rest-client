using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace FaxCoreRestClient.Models.Request
{
    [DataContract]
    public class ActivateUser
    {
        /// <summary>
        ///     Gets or Sets UserIDList
        /// </summary>
        [DataMember(Name = "UserIDList", EmitDefaultValue = false)]
        [JsonPropertyName("userIdList")]
        public IEnumerable<string> UserIDList { get; set; }
    }
}