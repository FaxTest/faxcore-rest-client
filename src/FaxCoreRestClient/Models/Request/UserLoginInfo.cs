using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace FaxCoreRestClient.Models.Request
{
    /// <summary>
    ///     User Login configuration when using a third party authentication service.
    /// </summary>
    public class UserLoginInfo
    {
        /// <summary>
        ///     The login provider to use for this user
        /// </summary>
        [DataMember(Name = "loginProvider", EmitDefaultValue = false)]
        [JsonPropertyName("loginProvider")]
        public string LoginProvider { get; set; }

        /// <summary>
        ///     The provider key to use for this user
        /// </summary>
        [DataMember(Name = "providerKey", EmitDefaultValue = false)]
        [JsonPropertyName("providerKey")]
        public string ProviderKey { get; set; }
    }
}