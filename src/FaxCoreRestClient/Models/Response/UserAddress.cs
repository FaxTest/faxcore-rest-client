using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace FaxCore.Ev6.RestClient.Models.Response
{
    public class UserAddress
    {
        /// <summary>
        ///     The Address ID
        /// </summary>
        [DataMember(Name = "addressID", EmitDefaultValue = false)]
        [JsonPropertyName("addressID")]
        public string AddressId { get; set; }

        /// <summary>
        ///     The Address Type
        /// </summary>
        [DataMember(Name = "addressType", EmitDefaultValue = false)]
        [JsonPropertyName("addressType")]
        public string AddressType { get; set; }

        /// <summary>
        ///     The Address
        /// </summary>
        [DataMember(Name = "address", EmitDefaultValue = false)]
        [JsonPropertyName("address")]
        public string Address { get; set; }

        /// <summary>
        ///     Is this the primary address for this user?
        /// </summary>
        [DataMember(Name = "isPrimary", EmitDefaultValue = false)]
        [JsonPropertyName("isPrimary")]
        public bool isPrimary { get; set; }

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
    }
}