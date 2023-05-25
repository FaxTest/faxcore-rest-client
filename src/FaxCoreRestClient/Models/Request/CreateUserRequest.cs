using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using FaxCoreRestClient.Models.Enumerators;

namespace FaxCoreRestClient.Models.Request
{
    /// <summary>
    ///     Request to create a user
    /// </summary>
    public class CreateUserRequest
    {
        /// <summary>
        ///     The DomainName where the user should be created
        /// </summary>
        [DataMember(Name = "domainName", EmitDefaultValue = false)]
        [JsonPropertyName("domainName")]
        public string DomainName { get; set; }

        /// <summary>
        ///     The Username of the user to create
        /// </summary>
        [DataMember(Name = "username", EmitDefaultValue = false)]
        [JsonPropertyName("username")]
        public string Username { get; set; }

        /// <summary>
        ///     The Password of the user to create. Minimum 6 characters, 1 uppercase, 1 lowercase, 1 digit and 1 symbol.
        /// </summary>
        [DataMember(Name = "password", EmitDefaultValue = false)]
        [JsonPropertyName("password")]
        public string Password { get; set; }

        /// <summary>
        ///     The Role of the user to create. <see cref="Role" />
        ///     1 = System Admin
        ///     2 = Domain Admin
        ///     3 = Super User
        ///     4 = Standard User
        /// </summary>
        [DataMember(Name = "role", EmitDefaultValue = false)]
        [JsonPropertyName("role")]
        public Role Role { get; set; }

        /// <summary>
        ///     Specify if the user is authenticated using a third party provider
        ///     True = External Authentication
        ///     False = FaxCore Authentication
        /// </summary>
        [DataMember(Name = "isExternalAuth", EmitDefaultValue = false)]
        [JsonPropertyName("isExternalAuth")]
        public bool IsExternalAuth { get; set; }

        /// <summary>
        ///     Specify if the user should be created in an active state
        /// </summary>
        [DataMember(Name = "isActive", EmitDefaultValue = false)]
        [JsonPropertyName("isActive")]
        public bool IsActive { get; set; }

        /// <summary>
        ///     The new user's display name
        /// </summary>
        [DataMember(Name = "displayName", EmitDefaultValue = false)]
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        ///     The new user's first name
        /// </summary>
        [DataMember(Name = "firstName", EmitDefaultValue = false)]
        [JsonPropertyName("firstName")]
        public string FirstName { get; set; }

        /// <summary>
        ///     The new user's last name
        /// </summary>
        [DataMember(Name = "lastName", EmitDefaultValue = false)]
        [JsonPropertyName("lastName")]
        public string LastName { get; set; }

        /// <summary>
        ///     The new user's company name
        /// </summary>
        [DataMember(Name = "companyName", EmitDefaultValue = false)]
        [JsonPropertyName("companyName")]
        public string CompanyName { get; set; }

        /// <summary>
        ///     Preferred address type of the user to create <see cref="PreferredAddressType" />
        /// </summary>
        [DataMember(Name = "preferredAddressType", EmitDefaultValue = false)]
        [JsonPropertyName("preferredAddressType")]
        public PreferredAddressType PreferredAddressType { get; set; }

        /// <summary>
        ///     The new user's email address
        /// </summary>
        [DataMember(Name = "email", EmitDefaultValue = false)]
        [JsonPropertyName("email")]
        public string Email { get; set; }

        /// <summary>
        ///     Should the creation of this user fire an email confirmation
        /// </summary>
        [DataMember(Name = "sentEmailConfirmation", EmitDefaultValue = false)]
        [JsonPropertyName("sentEmailConfirmation")]
        public bool SentEmailConfirmation { get; set; }

        /// <summary>
        ///     The fax number for this user (does not tie the user to a DID in FaxCore)
        /// </summary>
        [DataMember(Name = "faxNumber", EmitDefaultValue = false)]
        [JsonPropertyName("faxNumber")]
        public string FaxNumber { get; set; }

        /// <summary>
        /// </summary>
        [DataMember(Name = "rawFax", EmitDefaultValue = false)]
        [JsonPropertyName("rawFax")]
        public string RawFax { get; set; }

        /// <summary>
        ///     Notification on Receive (NOR)?
        /// </summary>
        [DataMember(Name = "nor", EmitDefaultValue = false)]
        [JsonPropertyName("nor")]
        public bool NotifyOnReceive { get; set; }

        /// <summary>
        ///     Notification on Send (NOS)?
        /// </summary>
        [DataMember(Name = "nos", EmitDefaultValue = false)]
        [JsonPropertyName("nos")]
        public bool NotifyOnSend { get; set; }

        /// <summary>
        ///     Description of the user
        /// </summary>
        [DataMember(Name = "desc", EmitDefaultValue = false)]
        [JsonPropertyName("desc")]
        public string Description { get; set; }

        /// <summary>
        ///     Caller ID to display when the user sends a fax
        /// </summary>
        [DataMember(Name = "callerID", EmitDefaultValue = false)]
        [JsonPropertyName("callerID")]
        public string CallerID { get; set; }

        /// <summary>
        ///     The called subscriber ID (CSID) to use when the user sends a fax
        /// </summary>
        [DataMember(Name = "csid", EmitDefaultValue = false)]
        [JsonPropertyName("csid")]
        public string CSID { get; set; }

        /// <summary>
        ///     Configuration for third party authentication <see cref="UserLoginInfo" />
        /// </summary>
        [DataMember(Name = "userLoginInfo", EmitDefaultValue = false)]
        [JsonPropertyName("userLoginInfo")]
        public UserLoginInfo UserLoginInfo { get; set; }
    }
}