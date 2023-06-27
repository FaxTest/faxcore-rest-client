using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace FaxCore.Ev6.RestClient.Models.Response
{
    public class UserData
    {
        /// <summary>
        ///     The UserId of the user
        /// </summary>
        [DataMember(Name = "userID", EmitDefaultValue = false)]
        [JsonPropertyName("userID")]
        public string UserId { get; set; }

        /// <summary>
        ///     The Username of the user
        /// </summary>
        [DataMember(Name = "username", EmitDefaultValue = false)]
        [JsonPropertyName("username")]
        public string Username { get; set; }

        /// <summary>
        ///     The users display name
        /// </summary>
        [DataMember(Name = "displayName", EmitDefaultValue = false)]
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        ///     The users first name
        /// </summary>
        [DataMember(Name = "firstName", EmitDefaultValue = false)]
        [JsonPropertyName("firstName")]
        public string FirstName { get; set; }

        /// <summary>
        ///     The users last name
        /// </summary>
        [DataMember(Name = "lastName", EmitDefaultValue = false)]
        [JsonPropertyName("lastName")]
        public string LastName { get; set; }

        /// <summary>
        ///     Preferred address type of the user
        /// </summary>
        [DataMember(Name = "preferAddrType", EmitDefaultValue = false)]
        [JsonPropertyName("preferAddrType")]
        public string PreferredAddressType { get; set; }

        /// <summary>
        ///     A list of the users notification addresses <see cref="UserAddress" />
        /// </summary>
        [DataMember(Name = "addresses", EmitDefaultValue = false)]
        [JsonPropertyName("addresses")]
        public IEnumerable<UserAddress> Addresses { get; set; }

        /// <summary>
        ///     The user's role
        /// </summary>
        [DataMember(Name = "role", EmitDefaultValue = false)]
        [JsonPropertyName("role")]
        public string Role { get; set; }

        /// <summary>
        ///     The user's authentication type
        /// </summary>
        [DataMember(Name = "authenticationType", EmitDefaultValue = false)]
        [JsonPropertyName("authenticationType")]
        public string AuthenticationType { get; set; }

        /// <summary>
        ///     Is the user active
        /// </summary>
        [DataMember(Name = "isActive", EmitDefaultValue = false)]
        [JsonPropertyName("isActive")]
        public bool IsActive { get; set; }

        /// <summary>
        ///     Description of the user
        /// </summary>
        [DataMember(Name = "desc", EmitDefaultValue = false)]
        [JsonPropertyName("desc")]
        public string Description { get; set; }

        /// <summary>
        ///     The users company name
        /// </summary>
        [DataMember(Name = "companyName", EmitDefaultValue = false)]
        [JsonPropertyName("companyName")]
        public string CompanyName { get; set; }
    }
}