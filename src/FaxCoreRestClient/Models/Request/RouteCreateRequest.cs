using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using FaxCore.Ev6.RestClient.Models.Enumerators;

namespace FaxCore.Ev6.RestClient.Models.Request
{
    /// <summary>
    ///     A request object for creating a new inbound routing rule
    /// </summary>
    public class RouteCreateRequest
    {
        /// <summary>
        ///     The user name of the user to whom the fax will be forwarded.
        /// </summary>
        [DataMember(Name = "forwardedUserName")]
        [JsonPropertyName("forwardedUserName")]
        public string ForwardedUserName { get; set; }

        /// <summary>
        ///     The routing condition to match on
        /// </summary>
        [DataMember(Name = "condition1")]
        [JsonPropertyName("condition1")]
        public RoutingCondition Condition1 { get; set; }

        /// <summary>
        ///     The value to match on based on the condition
        /// </summary>
        [DataMember(Name = "conditionExp1")]
        [JsonPropertyName("conditionExp1")]
        public string Condition1Expression { get; set; }

        /// <summary>
        ///     The operator to use when matching the conditions
        ///     <para>True = AND</para>
        ///     False = OR
        /// </summary>
        [DataMember(Name = "isAndOperator")]
        [JsonPropertyName("isAndOperator")]
        public bool IsAndOperator { get; set; }

        /// <summary>
        ///     The second routing condition to match on
        /// </summary>
        [DataMember(Name = "condition2")]
        [JsonPropertyName("condition2")]
        public RoutingCondition Condition2 { get; set; }

        /// <summary>
        ///     The value to match on based on the second condition
        /// </summary>
        [DataMember(Name = "conditionExp2")]
        [JsonPropertyName("conditionExp2")]
        public string Condition2Expression { get; set; }

        /// <summary>
        ///     Sets the routing rule to be active or inactive
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