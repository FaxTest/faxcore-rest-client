using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace FaxCoreRestClient.Models
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

    /// <summary>
    ///     Represents a barcode.
    /// </summary>
    [DataContract]
    public class Barcode
    {
        /// <summary>
        ///     Gets or sets the barcode value.
        /// </summary>
        [DataMember(Name = "barcodeValue")]
        [JsonPropertyName("barcodeValue")]
        public string BarcodeValue { get; set; }

        /// <summary>
        ///     Gets or sets the barcode type.
        /// </summary>
        [DataMember(Name = "barcodeType")]
        [JsonPropertyName("barcodeType")]
        public string BarcodeType { get; set; }

        /// <summary>
        ///     Gets or sets the barcode page location.
        /// </summary>
        [DataMember(Name = "barcodePageLocation")]
        [JsonPropertyName("barcodePageLocation")]
        public string BarcodePageLocation { get; set; }
    }

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