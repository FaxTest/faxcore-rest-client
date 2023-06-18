using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace FaxCore.Ev6.RestClient.Models.Response
{
    public class RouteSearchResponse
    {
        /// <summary>
        ///     The unique ID of the route
        /// </summary>
        [DataMember(Name = "routeID")]
        [JsonPropertyName("routeID")]
        public int RouteId { get; set; }

        /// <summary>
        ///     The value to route by
        /// </summary>
        [DataMember(Name = "routeByString")]
        [JsonPropertyName("routeByString")]
        public string RouteByString { get; set; }

        /// <summary>
        ///     The value to be forwarded to
        /// </summary>
        [DataMember(Name = "forwardedAddress")]
        [JsonPropertyName("forwardedAddress")]
        public string ForwardAddress { get; set; }

        /// <summary>
        ///     Indicates if the rule is time based
        /// </summary>
        [DataMember(Name = "isTimeBasedRoute")]
        [JsonPropertyName("isTimeBasedRoute")]
        public bool IsTimeBasedRoute { get; set; }

        /// <summary>
        ///     Is this a route that doesn't send out but directly delivers to another user?
        /// </summary>
        [DataMember(Name = "isLoopBack")]
        [JsonPropertyName("isLoopBack")]
        public bool IsLoopBack { get; set; }

        /// <summary>
        ///     Indicates if the rule is active
        /// </summary>
        [DataMember(Name = "isActive")]
        [JsonPropertyName("isActive")]
        public bool IsActive { get; set; }

        /// <summary>
        ///     <para>The priority matching order of the rule. The lower the number, the higher the priority.</para>
        ///     <para>(1 - 9999)</para>
        /// </summary>
        [DataMember(Name = "priority")]
        [JsonPropertyName("priority")]
        public int Priority { get; set; }
    }
}