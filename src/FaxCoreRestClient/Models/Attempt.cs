using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace FaxCoreRestClient.Models
{
    /// <summary>
    ///     Represents an attempt made for a transaction.
    /// </summary>
    [DataContract]
    public class Attempt
    {
        /// <summary>
        ///     Gets or sets the transmission ID of the attempt.
        /// </summary>
        [DataMember(Name = "transmissionID")]
        [JsonPropertyName("transmissionID")]
        public string TransmissionID { get; set; }

        /// <summary>
        ///     Gets or sets the created date of the attempt.
        /// </summary>
        [DataMember(Name = "createdDate")]
        [JsonPropertyName("createdDate")]
        public string AttemptCreatedDate { get; set; }

        /// <summary>
        ///     Gets or sets the scheduled date of the attempt.
        /// </summary>
        [DataMember(Name = "scheduleDate")]
        [JsonPropertyName("scheduleDate")]
        public string AttemptScheduleDate { get; set; }

        /// <summary>
        ///     Gets or sets the complete date of the attempt.
        /// </summary>
        [DataMember(Name = "completeDate")]
        [JsonPropertyName("completeDate")]
        public string AttemptCompleteDate { get; set; }

        /// <summary>
        ///     Gets or sets the calling number of the attempt.
        /// </summary>
        [DataMember(Name = "callingNumber")]
        [JsonPropertyName("callingNumber")]
        public string CallingNumber { get; set; }

        /// <summary>
        ///     Gets or sets the called number of the attempt.
        /// </summary>
        [DataMember(Name = "calledNumber")]
        [JsonPropertyName("calledNumber")]
        public string CalledNumber { get; set; }

        /// <summary>
        ///     Gets or sets the remote CSID of the attempt.
        /// </summary>
        [DataMember(Name = "remoteCSID")]
        [JsonPropertyName("remoteCSID")]
        public string RemoteCSID { get; set; }

        /// <summary>
        ///     Gets or sets the routing information of the attempt.
        /// </summary>
        [DataMember(Name = "routingInfo")]
        [JsonPropertyName("routingInfo")]
        public string RoutingInfo { get; set; }

        /// <summary>
        ///     Gets or sets the fax protocol of the attempt.
        /// </summary>
        [DataMember(Name = "faxProtocol")]
        [JsonPropertyName("faxProtocol")]
        public string FaxProtocol { get; set; }

        /// <summary>
        ///     Gets or sets the transmit speed of the attempt.
        /// </summary>
        [DataMember(Name = "transmitSpeed")]
        [JsonPropertyName("transmitSpeed")]
        public string TransmitSpeed { get; set; }

        /// <summary>
        ///     Gets or sets the compression mode of the attempt.
        /// </summary>
        [DataMember(Name = "compressionMode")]
        [JsonPropertyName("compressionMode")]
        public string CompressionMode { get; set; }

        /// <summary>
        ///     Gets or sets the call duration of the attempt.
        /// </summary>
        [DataMember(Name = "callDuration")]
        [JsonPropertyName("callDuration")]
        public string CallDuration { get; set; }

        /// <summary>
        ///     Gets or sets the transmit duration of the attempt.
        /// </summary>
        [DataMember(Name = "transmitDuration")]
        [JsonPropertyName("transmitDuration")]
        public string TransmitDuration { get; set; }

        /// <summary>
        ///     Gets or sets the fax resolution of the attempt.
        /// </summary>
        [DataMember(Name = "faxResolution")]
        [JsonPropertyName("faxResolution")]
        public string FaxResolution { get; set; }

        /// <summary>
        ///     Gets or sets the transmit status of the attempt.
        /// </summary>
        [DataMember(Name = "transmitStatus")]
        [JsonPropertyName("transmitStatus")]
        public string TransmitStatus { get; set; }

        /// <summary>
        ///     Gets or sets the transmit status definition of the attempt.
        /// </summary>
        [DataMember(Name = "transmitStatusDef")]
        [JsonPropertyName("transmitStatusDef")]
        public string TransmitStatusDef { get; set; }

        /// <summary>
        ///     Gets or sets the attempt number.
        /// </summary>
        [DataMember(Name = "attemptNo")]
        [JsonPropertyName("attemptNo")]
        public string AttemptNo { get; set; }

        /// <summary>
        ///     Gets or sets the maximum attempt number.
        /// </summary>
        [DataMember(Name = "maxAttemptNo")]
        [JsonPropertyName("maxAttemptNo")]
        public string MaxAttemptNo { get; set; }

        /// <summary>
        ///     Gets or sets the page count of the attempt.
        /// </summary>
        [DataMember(Name = "pageCount")]
        [JsonPropertyName("pageCount")]
        public string AttemptPageCount { get; set; }

        /// <summary>
        ///     Gets or sets the start page number of the attempt.
        /// </summary>
        [DataMember(Name = "startPageNo")]
        [JsonPropertyName("startPageNo")]
        public string StartPageNo { get; set; }

        /// <summary>
        ///     Gets or sets the number of pages sent in the attempt.
        /// </summary>
        [DataMember(Name = "pageSent")]
        [JsonPropertyName("pageSent")]
        public string PageSent { get; set; }

        /// <summary>
        ///     Gets or sets the fax agent ID of the attempt.
        /// </summary>
        [DataMember(Name = "faxAgentID")]
        [JsonPropertyName("faxAgentID")]
        public string FaxAgentID { get; set; }

        /// <summary>
        ///     Gets or sets the port number of the attempt.
        /// </summary>
        [DataMember(Name = "portNo")]
        [JsonPropertyName("portNo")]
        public string PortNo { get; set; }

        /// <summary>
        ///     Gets or sets the board ID of the attempt.
        /// </summary>
        [DataMember(Name = "boardID")]
        [JsonPropertyName("boardID")]
        public string BoardID { get; set; }

        /// <summary>
        ///     Gets or sets the server IP of the attempt.
        /// </summary>
        [DataMember(Name = "serverIP")]
        [JsonPropertyName("serverIP")]
        public string ServerIP { get; set; }

        /// <summary>
        ///     Gets or sets the error ID of the attempt.
        /// </summary>
        [DataMember(Name = "errorID")]
        [JsonPropertyName("errorID")]
        public string ErrorID { get; set; }

        /// <summary>
        ///     Gets or sets the error information of the attempt.
        /// </summary>
        [DataMember(Name = "errorInfo")]
        [JsonPropertyName("errorInfo")]
        public string ErrorInfo { get; set; }
    }
}