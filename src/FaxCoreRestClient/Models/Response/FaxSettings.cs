using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace FaxCoreRestClient.Models.Response
{
    /// <summary>
    ///     Fax Settings for a user. Note that these are read only as of FaxCore 2.0.  This is because
    ///     FaxCore does not support the ability to set these values using the API.
    /// </summary>
    public class FaxSettings
    {
        /// <summary>
        ///     The User ID
        /// </summary>
        [DataMember(Name = "userID")]
        [JsonPropertyName("userID")]
        public int UserId { get; set; }

        /// <summary>
        ///     The Country Code for the user
        /// </summary>
        [DataMember(Name = "countryCode")]
        [JsonPropertyName("countryCode")]
        public string CountryCode { get; set; }

        /// <summary>
        ///     The Area Code for the user
        /// </summary>
        [DataMember(Name = "areaCode")]
        [JsonPropertyName("areaCode")]
        public string AreaCode { get; set; }

        /// <summary>
        ///     The dialing prefix for the user
        /// </summary>
        [DataMember(Name = "dialPrefix")]
        [JsonPropertyName("dialPrefix")]
        public string DialPrefix { get; set; }

        /// <summary>
        ///     The dialing prefix rule for the user
        /// </summary>
        [DataMember(Name = "dialPrefixRule")]
        [JsonPropertyName("dialPrefixRule")]
        public string DialPrefixRule { get; set; }

        /// <summary>
        ///     The dialing suffix for the user
        /// </summary>
        [DataMember(Name = "dialSuffix")]
        [JsonPropertyName("dialSuffix")]
        public string DialSuffix { get; set; }

        /// <summary>
        ///     The dialing suffix rule for the user
        /// </summary>
        [DataMember(Name = "dialSuffixRule")]
        [JsonPropertyName("dialSuffixRule")]
        public string DialSuffixRule { get; set; }

        /// <summary>
        ///     The called subscriber ID for the user
        /// </summary>
        [DataMember(Name = "localCSID")]
        [JsonPropertyName("localCSID")]
        public string LocalCSID { get; set; }

        /// <summary>
        ///     The caller ID for the user
        /// </summary>
        [DataMember(Name = "localCallerID")]
        [JsonPropertyName("localCallerID")]
        public string LocalCallerID { get; set; }

        /// <summary>
        ///     The local number for the user
        /// </summary>
        [DataMember(Name = "localNumber")]
        [JsonPropertyName("localNumber")]
        public string LocalNumber { get; set; }

        /// <summary>
        ///     The format of the fax FAX or RAW FAX
        /// </summary>
        [DataMember(Name = "defaultSendFaxFormat")]
        [JsonPropertyName("defaultSendFaxFormat")]
        public string DefaultSendFaxFormat { get; set; }

        /// <summary>
        ///     The format for emails when requesting to
        ///     send faxes either WITH ATTACHMENT
        ///     or WITHOUT ATTACHMENT
        /// </summary>
        [DataMember(Name = "emailSendNotificationFormat")]
        [JsonPropertyName("emailSendNotificationFormat")]
        public string EmailSendNotificationFormat { get; set; }

        /// <summary>
        ///     The message size limit for email attachments when
        ///     sending a fax.
        /// </summary>
        [DataMember(Name = "emailSendAttachMaxSize")]
        [JsonPropertyName("emailSendAttachMaxSize")]
        public string EmailSendAttachMaxSize { get; set; }

        /// <summary>
        ///     The default resolution for outbound faxes for this
        ///     user. Either FINE (204x196) or STANDARD (204x98)
        /// </summary>
        [DataMember(Name = "resolution")]
        [JsonPropertyName("resolution")]
        public string Resolution { get; set; }

        /// <summary>
        ///     The fax header format for outbound faxes.
        /// </summary>
        [DataMember(Name = "faxHeader")]
        [JsonPropertyName("faxHeader")]
        public string FaxHeader { get; set; }

        /// <summary>
        ///     The maximum number of pages per transaction
        ///     that this user can send (0 = unlimited)
        /// </summary>
        [DataMember(Name = "pageSendLimit")]
        [JsonPropertyName("pageSendLimit")]
        public string PageSendLimit { get; set; }

        /// <summary>
        ///     Can this user receive partial faxes if the
        ///     call fails? YES or NO
        /// </summary>
        [DataMember(Name = "allowFaxRecvPartially")]
        [JsonPropertyName("allowFaxRecvPartially")]
        public string AllowFaxRecvPartially { get; set; }

        /// <summary>
        ///     The format for emails when receiving
        ///     faxes to email either WITH ATTACHMENT
        ///     or WITHOUT ATTACHMENT
        /// </summary>
        [DataMember(Name = "emailRecvNotifyFormat")]
        [JsonPropertyName("emailRecvNotifyFormat")]
        public string EmailRecvNotifyFormat { get; set; }

        /// <summary>
        ///     The maximum size of an email attachment
        /// </summary>
        [DataMember(Name = "emailRecvAttachmentMaxSize")]
        [JsonPropertyName("emailRecvAttachmentMaxSize")]
        public string EmailRecvAttachmentMaxSize { get; set; }

        /// <summary>
        ///     The Unassigned Message User for this user
        /// </summary>
        [DataMember(Name = "unassignedMessageUser")]
        [JsonPropertyName("unassignedMessageUser")]
        public string UnassignedMessageUser { get; set; }

        /// <summary>
        ///     The default cover page for this user
        /// </summary>
        [DataMember(Name = "defaultSendCoverPage")]
        [JsonPropertyName("defaultSendCoverPage")]
        public string DefaultSendCoverPage { get; set; }
    }
}