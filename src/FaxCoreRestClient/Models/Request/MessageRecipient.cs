using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace FaxCoreRestClient.Models.Request
{
    /// <summary>
    ///     Represents a recipient object.
    /// </summary>
    public class MessageRecipient
    {
        /// <summary>
        ///     Gets or sets the name of the recipient.
        /// </summary>
        [DataMember(Name = "name")]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        ///     Gets or sets the address of the recipient.
        /// </summary>
        [DataMember(Name = "address")]
        [JsonPropertyName("address")]
        public string Address { get; set; }

        /// <summary>
        ///     Set whether the fax number should be dialed as is without any formatting. (Not valid for email)
        /// </summary>
        [DataMember(Name = "rawFax")]
        [JsonPropertyName("rawFax")]
        public bool IsRawFax { get; set; }

        /// <summary>
        ///     Gets or sets the notification address of the recipient.
        /// </summary>
        [DataMember(Name = "notifyAddress")]
        [JsonPropertyName("notifyAddress")]
        public string NotifyAddress { get; set; }

        /// <summary>
        ///     Gets or sets the company of the recipient.
        /// </summary>
        [DataMember(Name = "company")]
        [JsonPropertyName("company")]
        public string Company { get; set; }
    }
}