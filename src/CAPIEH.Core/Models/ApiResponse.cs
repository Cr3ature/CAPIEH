using System;
using System.Net;

namespace CAPIEH
{
    /// <summary>
    /// Response for API request success.
    /// </summary>
    /// <typeparam name="TOutputType"></typeparam>
    [Serializable]
    public class ApiResponse<TOutputType>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="outputType"></param>
        /// <param name="status"></param>
        public ApiResponse(TOutputType outputType, ApiResponseStatus status = ApiResponseStatus.Ok)
        {
            Data = outputType;
            Status = status.Equals(ApiResponseStatus.Ok).ToString();
            StatusCode = HttpStatusCode.OK;
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="outputType"></param>
        /// <param name="statusCode"></param>
        /// <param name="status"></param>
        public ApiResponse(TOutputType outputType, HttpStatusCode statusCode, ApiResponseStatus status = ApiResponseStatus.Ok)
        {
            Data = outputType;
            Status = status.Equals(ApiResponseStatus.Ok).ToString();
            StatusCode = StatusCode;
        }

        /// <summary>
        /// Response data
        /// </summary>
        public TOutputType Data { get; }

        /// <summary>
        /// Flag is by default set to <see cref="ApiResponseStatus.Ok"/>.
        /// </summary>
        public string Status { get; }

        /// <summary>
        /// The <see cref="HttpStatusCode"/>.
        /// </summary>
        public HttpStatusCode StatusCode { get; }
    }
}
