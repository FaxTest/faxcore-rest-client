using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace FaxCore.Ev6.RestClient.Models
{
    /// <summary>
    ///     Represents a transaction.
    /// </summary>
    [DataContract]
    public class Transaction
    {
        /// <summary>
        ///     Gets or sets the transaction ID.
        /// </summary>
        [DataMember(Name = "transactionID")]
        [JsonPropertyName("transactionID")]
        public string TransactionID { get; set; }

        /// <summary>
        ///     Gets or sets the document ID.
        /// </summary>
        [DataMember(Name = "documentID")]
        [JsonPropertyName("documentID")]
        public string DocumentID { get; set; }

        /// <summary>
        ///     Gets or sets the address type ID.
        /// </summary>
        [DataMember(Name = "addressTypeID")]
        [JsonPropertyName("addressTypeID")]
        public string AddressTypeID { get; set; }

        /// <summary>
        ///     Gets or sets the address type definition.
        /// </summary>
        [DataMember(Name = "addressTypeDef")]
        [JsonPropertyName("addressTypeDef")]
        public string AddressTypeDef { get; set; }

        /// <summary>
        ///     Gets or sets the transaction sequence.
        /// </summary>
        [DataMember(Name = "transactionSeq")]
        [JsonPropertyName("transactionSeq")]
        public string TransactionSeq { get; set; }

        /// <summary>
        ///     Gets or sets the transaction type ID.
        /// </summary>
        [DataMember(Name = "transactionTypeID")]
        [JsonPropertyName("transactionTypeID")]
        public string TransactionTypeID { get; set; }

        /// <summary>
        ///     Gets or sets the transaction type definition.
        /// </summary>
        [DataMember(Name = "transactionTypeDef")]
        [JsonPropertyName("transactionTypeDef")]
        public string TransactionTypeDef { get; set; }

        /// <summary>
        ///     Gets or sets the transmit error ID.
        /// </summary>
        [DataMember(Name = "transmitErrorID")]
        [JsonPropertyName("transmitErrorID")]
        public string TransmitErrorID { get; set; }

        /// <summary>
        ///     Gets or sets the transmit error information.
        /// </summary>
        [DataMember(Name = "transmitErrorInfo")]
        [JsonPropertyName("transmitErrorInfo")]
        public string TransmitErrorInfo { get; set; }

        /// <summary>
        ///     Gets or sets the recipient name.
        /// </summary>
        [DataMember(Name = "recipientName")]
        [JsonPropertyName("recipientName")]
        public string RecipientName { get; set; }

        /// <summary>
        ///     Gets or sets the recipient company name.
        /// </summary>
        [DataMember(Name = "recipientCompanyName")]
        [JsonPropertyName("recipientCompanyName")]
        public string RecipientCompanyName { get; set; }

        /// <summary>
        ///     Gets or sets the message display address.
        /// </summary>
        [DataMember(Name = "messageDisplayAddress")]
        [JsonPropertyName("messageDisplayAddress")]
        public string MessageDisplayAddress { get; set; }

        /// <summary>
        ///     Gets or sets the dial string.
        /// </summary>
        [DataMember(Name = "dialString")]
        [JsonPropertyName("dialString")]
        public string DialString { get; set; }

        /// <summary>
        ///     Gets or sets the number of attempts made.
        /// </summary>
        [DataMember(Name = "numberOfAttempts")]
        [JsonPropertyName("numberOfAttempts")]
        public string NumberOfAttempts { get; set; }

        /// <summary>
        ///     Gets or sets the page count.
        /// </summary>
        [DataMember(Name = "pageCount")]
        [JsonPropertyName("pageCount")]
        public string PageCount { get; set; }

        /// <summary>
        ///     Gets or sets the number of pages sent.
        /// </summary>
        [DataMember(Name = "pageSent")]
        [JsonPropertyName("pageSent")]
        public string PageSent { get; set; }

        /// <summary>
        ///     Gets or sets the transaction status definition.
        /// </summary>
        [DataMember(Name = "transactionStatusDef")]
        [JsonPropertyName("transactionStatusDef")]
        public string TransactionStatusDef { get; set; }

        /// <summary>
        ///     Gets or sets the transaction status.
        /// </summary>
        [DataMember(Name = "transactionStatus")]
        [JsonPropertyName("transactionStatus")]
        public string TransactionStatus { get; set; }

        /// <summary>
        ///     Gets or sets the local CSID.
        /// </summary>
        [DataMember(Name = "localCSID")]
        [JsonPropertyName("localCSID")]
        public string LocalCSID { get; set; }

        /// <summary>
        ///     Gets or sets the remote CSID.
        /// </summary>
        [DataMember(Name = "remoteCSID")]
        [JsonPropertyName("remoteCSID")]
        public string RemoteCSID { get; set; }

        /// <summary>
        ///     Gets or sets the transmit speed.
        /// </summary>
        [DataMember(Name = "transmitSpeed")]
        [JsonPropertyName("transmitSpeed")]
        public string TransmitSpeed { get; set; }

        /// <summary>
        ///     Gets or sets the total transmit time.
        /// </summary>
        [DataMember(Name = "totalTransmitTime")]
        [JsonPropertyName("totalTransmitTime")]
        public string TotalTransmitTime { get; set; }

        /// <summary>
        ///     Gets or sets the created date of the transaction.
        /// </summary>
        [DataMember(Name = "createdDate")]
        [JsonPropertyName("createdDate")]
        public string TransactionCreatedDate { get; set; }

        /// <summary>
        ///     Gets or sets the complete date of the transaction.
        /// </summary>
        [DataMember(Name = "completeDate")]
        [JsonPropertyName("completeDate")]
        public string TransactionCompleteDate { get; set; }

        /// <summary>
        ///     Gets or sets the list of attempts made.
        /// </summary>
        [DataMember(Name = "attempts")]
        [JsonPropertyName("attempts")]
        public List<Attempt> Attempts { get; set; }

        /// <summary>
        ///     Gets or sets the value indicating whether the transaction is a failed notification.
        /// </summary>
        [DataMember(Name = "isFailedNotification")]
        [JsonPropertyName("isFailedNotification")]
        public bool IsFailedNotification { get; set; }
    }
}