namespace CAPIEH
{
    using System;
    using System.Net;

    /// <summary>
    /// Response for API request success.
    /// </summary>
    /// <typeparam name="TOutputType">Type of the OutputType.</typeparam>
    [Serializable]
#nullable enable
    public class ApiResponse<TOutputType>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiResponse{TOutputType}" /> class.
        /// </summary>
        /// <param name="dataResponse">Response parameters for dataResponse.</param>
        public ApiResponse(DataResponse<TOutputType> dataResponse)
        {
            Data = dataResponse.Data;
            Status = dataResponse.Status.ToString();
            StatusCode = dataResponse.StatusCode;
            Error = default;
        }

        public ApiResponse(ErrorResponse errorResponse)
        {
            Data = default;
            Status = errorResponse.Status.ToString();
            StatusCode = errorResponse.StatusCode;
            Error = errorResponse.Error;
        }

        /// <summary>
        /// Gets the Data Response data.
        /// </summary>
        public TOutputType? Data { get; }

        /// <summary>
        /// Gets the Error Error details.
        /// </summary>
        public ErrorInfo? Error { get; }

        /// <summary>
        /// Gets the Status Flag.
        /// </summary>
        public string Status { get; }

        /// <summary>
        /// Gets the StatusCode The <see cref="HttpStatusCode" />.
        /// </summary>
        public HttpStatusCode StatusCode { get; }
    }

#nullable restore
}
