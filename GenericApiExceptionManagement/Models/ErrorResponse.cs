using System;
using System.Net;

namespace GenericApiExceptionManagement
{
    /// <summary>
    /// Error response for API request failures.
    /// </summary>
    [Serializable]
    public class ErrorResponse
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="errorType"></param>
        /// <param name="statusCode"></param>
        /// <param name="errorId"></param>
        /// <param name="message"></param>
        /// <param name="info"></param>
        public ErrorResponse(ErrorType errorType, HttpStatusCode statusCode, Guid errorId, string message, object info = null)
        {
            StatusCode = statusCode;
            Error = new ErrorInfo(
                type: errorType.ToString(),
                id: errorId,
                message: message,
                info: info);
        }

        /// <summary>
        /// Error details.
        /// </summary>
        public ErrorInfo Error { get; }

        /// <summary>
        /// Flag is always set to <see cref="ApiResponseStatus.NotOk"/>.
        /// </summary>
        public string Status => ApiResponseStatus.NotOk.ToString();

        /// <summary>
        /// The <see cref="HttpStatusCode"/>.
        /// </summary>
        public HttpStatusCode StatusCode { get; }
    }
}
