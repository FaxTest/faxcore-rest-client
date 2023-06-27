using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using FaxCore.Ev6.RestClient.Models.Enumerators;

namespace FaxCore.Ev6.RestClient.Models.Request
{
    /// <summary>
    ///     Create Contact Request
    /// </summary>
    public class CreateContactRequest
    {
        /// <summary>
        ///     The Address Book Id to add the contact to
        /// </summary>
        [DataMember(Name = "addressBookID")]
        [JsonPropertyName("addressBookID")]
        public int AddressBookId { get; set; }

        /// <summary>
        ///     The Contact's Display Name
        /// </summary>
        [DataMember(Name = "displayName")]
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        ///     The Contact's First Name
        /// </summary>
        [DataMember(Name = "firstName")]
        [JsonPropertyName("firstName")]
        public string FirstName { get; set; }

        /// <summary>
        ///     The Contact's Last Name
        /// </summary>
        [DataMember(Name = "lastName")]
        [JsonPropertyName("lastName")]
        public string LastName { get; set; }

        /// <summary>
        ///     The Contact's Company Name
        /// </summary>
        [DataMember(Name = "compName")]
        [JsonPropertyName("compName")]
        public string CompanyName { get; set; }

        /// <summary>
        ///     The contact's preferred contact address type
        /// </summary>
        [DataMember(Name = "preferredAddressType")]
        [JsonPropertyName("preferredAddressType")]
        public AddressType PreferredAddressType { get; set; }

        /// <summary>
        ///     The description of the contact
        /// </summary>
        [DataMember(Name = "description")]
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        ///     Should this contact be notified on failed faxes
        /// </summary>
        [DataMember(Name = "notifyOnFailed")]
        [JsonPropertyName("notifyOnFailed")]
        public bool NotifyOnFailed { get; set; }

        /// <summary>
        ///     Should this contact be notified on successful faxes
        /// </summary>
        [DataMember(Name = "notifyOnSuccess")]
        [JsonPropertyName("notifyOnSuccess")]
        public bool NotifyOnSuccess { get; set; }

        /// <summary>
        ///     Should this contact be notified on sent faxes
        /// </summary>
        [DataMember(Name = "addresses")]
        [JsonPropertyName("addresses")]
        public IList<ContactAddressRequest> Addresses { get; set; }
    }
}