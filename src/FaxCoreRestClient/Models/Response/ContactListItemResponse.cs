using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using FaxCoreRestClient.Models.Enumerators;

namespace FaxCoreRestClient.Models.Response
{
    public class ContactListItemResponse
    {
        /// <summary>
        ///     The unique identifier for the contact.
        /// </summary>
        [DataMember(Name = "contactID")]
        [JsonPropertyName("contactID")]
        public int ContactId { get; set; }

        /// <summary>
        ///     The Contact's Display Name
        /// </summary>
        [DataMember(Name = "displayName")]
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        ///     The Contact's Company Name
        /// </summary>
        [DataMember(Name = "companyName")]
        [JsonPropertyName("companyName")]
        public string CompanyName { get; set; }

        /// <summary>
        ///     The contacts message address
        /// </summary>
        [DataMember(Name = "address")]
        [JsonPropertyName("address")]
        public string Address { get; set; }

        /// <summary>
        ///     The contacts message address type
        /// </summary>
        [DataMember(Name = "addressType")]
        [JsonPropertyName("addressType")]
        public AddressType AddressType { get; set; }

        /// <summary>
        ///     The contacts notification address
        /// </summary>
        [DataMember(Name = "notifyAddress")]
        [JsonPropertyName("notifyAddress")]
        public string NotifyAddress { get; set; }
    }
}