using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace FaxCoreRestClient.Models.Response
{
    /// <summary>
    ///     Response object for the Cover Page Items
    /// </summary>
    public class CoverPageItemResponse
    {
        /// <summary>
        ///     The unique ID of the cover page item
        /// </summary>
        [DataMember(Name = "documentID")]
        [JsonPropertyName("documentID")]
        public string DocumentId { get; set; }

        /// <summary>
        ///     The name of the cover page item
        /// </summary>
        [DataMember(Name = "documentName")]
        [JsonPropertyName("documentName")]
        public string DocumentName { get; set; }
    }
}