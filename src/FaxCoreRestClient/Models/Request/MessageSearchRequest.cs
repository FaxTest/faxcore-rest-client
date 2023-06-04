using System;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using FaxCoreRestClient.Models.Enumerators;
using FaxCoreRestClient.Tools;

namespace FaxCoreRestClient.Models.Request
{
    public class MessageSearchRequest
    {
        /// <summary>
        ///     Filter by username (optional)
        /// </summary>
        [DataMember(Name = "userName")]
        [JsonPropertyName("userName")]
        public string UserName { get; set; }

        /// <summary>
        ///     Filter by date range starting with FromDate (optional)
        ///     Format: yyyyMMddd HH:mm:ss in UTC
        /// </summary>
        [JsonConverter(typeof(FaxCoreRequestDateTimeConverter))]
        [DataMember(Name = "fromDate")]
        [JsonPropertyName("fromDate")]
        public DateTime FromDate { get; set; }

        /// <summary>
        ///     Filter by date range ending with ToDate (optional)
        ///     Format: yyyyMMddd HH:mm:ss in UTC
        /// </summary>
        [JsonConverter(typeof(FaxCoreRequestDateTimeConverter))]
        [DataMember(Name = "toDate")]
        [JsonPropertyName("toDate")]
        public DateTime ToDate { get; set; }

        /// <summary>
        ///     Filter by message number (optional)
        /// </summary>
        [DataMember(Name = "messageNo")]
        [JsonPropertyName("messageNo")]
        public string MessageNo { get; set; }

        /// <summary>
        ///     Filter by tracking value (optional)
        /// </summary>
        [DataMember(Name = "trackValue")]
        [JsonPropertyName("trackValue")]
        public string TrackValue { get; set; }

        /// <summary>
        ///     Filter by recipient name (optional)
        /// </summary>
        [DataMember(Name = "recpName")]
        [JsonPropertyName("recpName")]
        public string RecipientName { get; set; }

        /// <summary>
        ///     Filter by recipient fax number (optional)
        /// </summary>
        [DataMember(Name = "faxAddr")]
        [JsonPropertyName("faxAddr")]
        public string FaxAddress { get; set; }

        /// <summary>
        ///     Filter by recipient email address (optional)
        /// </summary>
        [DataMember(Name = "email")]
        [JsonPropertyName("email")]
        public string Email { get; set; }

        /// <summary>
        ///     Filter by CSID (optional)
        /// </summary>
        [DataMember(Name = "localCSID")]
        [JsonPropertyName("localCSID")]
        public string LocalCSID { get; set; }

        /// <summary>
        ///     Filter by subject (optional)
        /// </summary>
        [DataMember(Name = "subject")]
        [JsonPropertyName("subject")]
        public string Subject { get; set; }

        /// <summary>
        ///     Filter by message direction (optional)
        ///     Valid values: Inbound, Outbound, Both
        /// </summary>
        [DataMember(Name = "messageType")]
        [JsonPropertyName("messageType")]
        public MessageDirection? MessageType { get; set; }

        /// <summary>
        ///     Filter failed messages
        ///     Valid values: Yes, No, All
        ///     (optional)
        /// </summary>
        [DataMember(Name = "isFailed")]
        [JsonPropertyName("isFailed")]
        public FilterOption? IsFailed { get; set; }

        /// <summary>
        ///     Filter held messages
        ///     Valid values: Yes, No, All
        ///     (optional)
        /// </summary>
        [DataMember(Name = "isHeld")]
        [JsonPropertyName("isHeld")]
        public FilterOption? IsHeld { get; set; }

        /// <summary>
        ///     Filter by routing info (optional)
        /// </summary>
        [DataMember(Name = "routingInfo")]
        [JsonPropertyName("routingInfo")]
        public string RoutingInfo { get; set; }

        /// <summary>
        ///     Filter by whether or not the message has been printed
        ///     Valid values: Yes, No, All
        ///     (optional)
        /// </summary>
        [DataMember(Name = "isPrinted")]
        [JsonPropertyName("isPrinted")]
        public FilterOption? IsPrinted { get; set; }

        /// <summary>
        ///     Filter by whether or not the message has been saved
        ///     Valid values: Yes, No, All
        ///     (optional)
        /// </summary>
        [DataMember(Name = "isSaved")]
        [JsonPropertyName("isSaved")]
        public FilterOption? IsSaved { get; set; }

        /// <summary>
        ///     Filter messages by status
        ///     (optional)
        /// </summary>
        [DataMember(Name = "status")]
        [JsonPropertyName("status")]
        public MessageStatus? Status { get; set; }

        /// <summary>
        ///     Include faxes in subdomains
        /// </summary>
        [JsonConverter(typeof(BooleanToStringConverter))]
        [DataMember(Name = "includeSubdomain")]
        [JsonPropertyName("includeSubdomain")]
        public bool IncludeSubdomain { get; set; }

        /// <summary>
        ///     Pagination options (optional)
        ///     <see cref="Pagination" />
        /// </summary>
        [DataMember(Name = "pagination")]
        [JsonPropertyName("pagination")]
        public Pagination Pagination { get; set; }
    }
}