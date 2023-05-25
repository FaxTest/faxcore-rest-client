using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace FaxCoreRestClient.Models.Request
{
    public class UpdateUserDetails
    {
        /// <summary>
        ///     Specify if the user is authenticated using a third party provider
        ///     True = External Authentication
        ///     False = FaxCore Authentication
        /// </summary>
        [DataMember(Name = "isExternalAuth")]
        [JsonPropertyName("isExternalAuth")]
        public bool IsExternalAuth { get; set; }

        /// <summary>
        ///     Specify if the user is active
        /// </summary>
        [DataMember(Name = "isActive")]
        [JsonPropertyName("isActive")]
        public bool IsActive { get; set; }

        /// <summary>
        ///     The user's display name
        /// </summary>
        [DataMember(Name = "displayName")]
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        ///     The user's first name
        /// </summary>
        [DataMember(Name = "firstName")]
        [JsonPropertyName("firstName")]
        public string FirstName { get; set; }

        /// <summary>
        ///     The user's last name
        /// </summary>
        [DataMember(Name = "lastName")]
        [JsonPropertyName("lastName")]
        public string LastName { get; set; }

        /// <summary>
        ///     The user's company name
        /// </summary>
        [DataMember(Name = "companyName")]
        [JsonPropertyName("companyName")]
        public string CompanyName { get; set; }

        /// <summary>
        ///     Preferred address type of the user <see cref="PreferredAddressType" />
        /// </summary>
        [DataMember(Name = "preferAddressType")]
        [JsonPropertyName("preferAddressType")]
        public string PreferAddressType { get; set; }

        /// <summary>
        ///     Description of the user
        /// </summary>
        [DataMember(Name = "desc")]
        [JsonPropertyName("desc")]
        public string Description { get; set; }

        /// <summary>
        ///     The called subscriber ID (CSID) to use when the user sends a fax
        /// </summary>
        [DataMember(Name = "localCSID")]
        [JsonPropertyName("localCSID")]
        public string LocalCSID { get; set; }

        /// <summary>
        ///     Caller ID to display when the user sends a fax
        /// </summary>
        [DataMember(Name = "callerID")]
        [JsonPropertyName("callerID")]
        public string CallerID { get; set; }
    }
}