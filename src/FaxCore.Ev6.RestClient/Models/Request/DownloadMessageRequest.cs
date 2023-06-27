using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace FaxCore.Ev6.RestClient.Models.Request
{
    public class DownloadMessageRequest
    {
        /// <summary>
        ///     message unique ID
        /// </summary>
        [DataMember(Name = "messageID")]
        [JsonPropertyName("messageID")]
        public string MessageID { get; set; }

        /// <summary>
        ///     Gets or sets the delivery number. This is a non-zero based index. This represent the sequence of transaction in a
        ///     message. For inbound message, the value always 1, there is only one transaction in inbound message.
        /// </summary>
        [DataMember(Name = "deliveryNum")]
        [JsonPropertyName("deliveryNum")]
        public int DeliveryNum { get; set; }

        /// <summary>
        ///     Format of the download file ('PDF' or 'TIF')
        /// </summary>
        [DataMember(Name = "downloadType")]
        [JsonPropertyName("downloadType")]
        public string DownloadType { get; set; }

        /// <summary>
        ///     The start page index (zero based). Indicates that the file will be downloaded starting from this page. (Optional)
        /// </summary>
        [DataMember(Name = "startPageIndex")]
        [JsonPropertyName("startPageIndex")]
        public int StartPageIndex { get; set; }

        /// <summary>
        ///     A list of page indexes (zero based) to be excluded from the download. (Optional)
        /// </summary>
        [DataMember(Name = "excludePageList")]
        [JsonPropertyName("excludePageList")]
        public List<int> ExcludePageList { get; set; }
    }
}