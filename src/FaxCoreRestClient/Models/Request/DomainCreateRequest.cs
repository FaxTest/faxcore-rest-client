using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace FaxCoreRestClient.Models.Request
{
    /// <summary>
    ///     The request object used to create a new domain.
    /// </summary>
    public class DomainCreateRequest
    {
        /// <summary>
        ///     The unique ID of the parent domain to create this domain under.
        /// </summary>
        [DataMember(Name = "parentDomainID")]
        [JsonPropertyName("parentDomainID")]
        public int ParentDomainId { get; set; }

        /// <summary>
        ///     The name of the domain to create.
        /// </summary>
        [DataMember(Name = "domainName")]
        [JsonPropertyName("domainName")]
        public string DomainName { get; set; }

        /// <summary>
        ///     The description of the domain to create.
        /// </summary>
        [DataMember(Name = "description")]
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        ///     Indicates if the domain will be created in an active state.
        /// </summary>
        [DataMember(Name = "isActive")]
        [JsonPropertyName("isActive")]
        public bool IsActive { get; set; }
    }
}