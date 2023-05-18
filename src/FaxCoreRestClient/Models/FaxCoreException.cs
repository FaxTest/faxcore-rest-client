using System;

namespace FaxCoreRestClient.Models
{
    /// <summary>
    ///     FaxCore Exception
    /// </summary>
    public class FaxCoreException : Exception
    {
        public FaxCoreException(string message, int errorCode, object httpResponse) : base(message)
        {
            ErrorCode = errorCode;
            HttpResponse = httpResponse;
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="FaxCoreException" /> class.
        /// </summary>
        /// <param name="errorCode">HTTP status code.</param>
        /// <param name="message">Error message.</param>
        public FaxCoreException(string message, int errorCode) : base(message)
        {
            ErrorCode = errorCode;
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="FaxCoreException" /> class.
        /// </summary>
        public FaxCoreException()
        {
        }

        /// <summary>
        ///     Gets or sets the error code.
        /// </summary>
        /// <value>The error code.</value>
        public int ErrorCode { get; set; }

        /// <summary>
        ///     Gets or sets the Http Response Body
        /// </summary>
        /// <value>The Http Response Body</value>
        public object HttpResponse { get; set; }
    }
}