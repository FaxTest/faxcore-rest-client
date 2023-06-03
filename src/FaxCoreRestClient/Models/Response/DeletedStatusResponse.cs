using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace FaxCoreRestClient.Models.Response
{
    public class DeletedStatusResponse
    {
        /// <summary>
        ///     Returns the status of a deleted fax status request.
        /// </summary>
        [DataMember(Name = "isDeleted")]
        [JsonPropertyName("isDeleted")]
        public string IsDeleted { get; set; }
    }
}