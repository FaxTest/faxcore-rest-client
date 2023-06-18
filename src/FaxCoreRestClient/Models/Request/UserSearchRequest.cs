using System.Text.Json.Serialization;

namespace FaxCore.Ev6.RestClient.Models.Request
{
    /// <summary>
    ///     User search request
    /// </summary>
    public class UserSearchRequest
    {
        /// <summary>
        ///     User ID of the user to search for
        /// </summary>
        [JsonPropertyName("username")]
        public string UserName { get; set; }

        /// <summary>
        ///     DisplayName of the user to search for
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        ///     Specify to search for active or inactive users
        /// </summary>
        [JsonPropertyName("active")]
        public string Active { get; set; }

        /// <summary>
        ///     First name of the user to search for
        /// </summary>
        [JsonPropertyName("firstName")]
        public string FirstName { get; set; }

        /// <summary>
        ///     Last name of the user to search for
        /// </summary>
        [JsonPropertyName("lastName")]
        public string LastName { get; set; }

        /// <summary>
        ///     Preferred address of the user to search for (email address)
        /// </summary>
        [JsonPropertyName("preferredAddress")]
        public string PreferredAddress { get; set; }

        /// <summary>
        ///     AllDomain
        /// </summary>
        [JsonPropertyName("allDomain")]
        public string AllDomain { get; set; }
    }
}