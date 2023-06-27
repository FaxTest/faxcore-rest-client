using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace FaxCore.Ev6.RestClient.Models
{
    /// <summary>
    ///     Represents the message object.
    /// </summary>
    public class Message
    {
        /// <summary>
        ///     Gets or sets the value indicating whether the message is read.
        /// </summary>
        [DataMember(Name = "isRead")]
        [JsonPropertyName("isRead")]
        public string IsRead { get; set; }

        /// <summary>
        ///     Gets or sets the user ID of the message owners.
        /// </summary>
        [DataMember(Name = "userID_MsgOwners")]
        [JsonPropertyName("userID_MsgOwners")]
        public string UserID_MsgOwners { get; set; }

        /// <summary>
        ///     Gets or sets the message ID.
        /// </summary>
        [DataMember(Name = "messageID")]
        [JsonPropertyName("messageID")]
        public string MessageID { get; set; }

        /// <summary>
        ///     Gets or sets the message number.
        /// </summary>
        [DataMember(Name = "messageNo")]
        [JsonPropertyName("messageNo")]
        public string MessageNo { get; set; }

        /// <summary>
        ///     Gets or sets the owner name.
        /// </summary>
        [DataMember(Name = "ownerName")]
        [JsonPropertyName("ownerName")]
        public string OwnerName { get; set; }

        /// <summary>
        ///     Gets or sets the owner domain.
        /// </summary>
        [DataMember(Name = "ownerDomain")]
        [JsonPropertyName("ownerDomain")]
        public string OwnerDomain { get; set; }

        /// <summary>
        ///     Gets or sets the message type.
        /// </summary>
        [DataMember(Name = "messageType")]
        [JsonPropertyName("messageType")]
        public string MessageType { get; set; }

        /// <summary>
        ///     Gets or sets the subject of the message.
        /// </summary>
        [DataMember(Name = "subject")]
        [JsonPropertyName("subject")]
        public string Subject { get; set; }

        /// <summary>
        ///     Gets or sets the tracking information.
        /// </summary>
        [DataMember(Name = "tracking")]
        [JsonPropertyName("tracking")]
        public string Tracking { get; set; }

        /// <summary>
        ///     Gets or sets the total number of documents.
        /// </summary>
        [DataMember(Name = "totalDocuments")]
        [JsonPropertyName("totalDocuments")]
        public string TotalDocuments { get; set; }

        /// <summary>
        ///     Gets or sets the total number of transactions.
        /// </summary>
        [DataMember(Name = "totalTransactions")]
        [JsonPropertyName("totalTransactions")]
        public string TotalTransactions { get; set; }

        /// <summary>
        ///     Gets or sets the total number of complete transactions.
        /// </summary>
        [DataMember(Name = "totalComplete")]
        [JsonPropertyName("totalComplete")]
        public string TotalComplete { get; set; }

        /// <summary>
        ///     Gets or sets the process count.
        /// </summary>
        [DataMember(Name = "processCount")]
        [JsonPropertyName("processCount")]
        public string ProcessCount { get; set; }

        /// <summary>
        ///     Gets or sets the created date of the message.
        /// </summary>
        [DataMember(Name = "createdDate")]
        [JsonPropertyName("createdDate")]
        public string CreatedDate { get; set; }

        /// <summary>
        ///     Gets or sets the scheduled date of the message.
        /// </summary>
        [DataMember(Name = "scheduleDate")]
        [JsonPropertyName("scheduleDate")]
        public string ScheduleDate { get; set; }

        /// <summary>
        ///     Gets or sets the complete date of the message.
        /// </summary>
        [DataMember(Name = "completeDate")]
        [JsonPropertyName("completeDate")]
        public string CompleteDate { get; set; }

        /// <summary>
        ///     Gets or sets the value indicating whether approval is required for the message.
        /// </summary>
        [DataMember(Name = "approvalRequired")]
        [JsonPropertyName("approvalRequired")]
        public string ApprovalRequired { get; set; }

        /// <summary>
        ///     Gets or sets the approval users for the message.
        /// </summary>
        [DataMember(Name = "approvalUsers")]
        [JsonPropertyName("approvalUsers")]
        public string ApprovalUsers { get; set; }

        /// <summary>
        ///     Gets or sets the list of barcodes.
        /// </summary>
        [DataMember(Name = "barcodes")]
        [JsonPropertyName("barcodes")]
        public List<Barcode> Barcodes { get; set; }

        /// <summary>
        ///     Gets or sets the list of transactions.
        /// </summary>
        [DataMember(Name = "transactions")]
        [JsonPropertyName("transactions")]
        public List<Transaction> Transactions { get; set; }

        /// <summary>
        ///     Gets or sets the status of the message.
        /// </summary>
        [DataMember(Name = "status")]
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        ///     Gets or sets the billing code.
        /// </summary>
        [DataMember(Name = "billingCode")]
        [JsonPropertyName("billingCode")]
        public string BillingCode { get; set; }
    }
}