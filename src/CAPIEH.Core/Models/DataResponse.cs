//-----------------------------------------------------------------------
// <copyright file="ErrorResponse.cs" company="David Vanderheyden">
//     Copyright (c) 2020 All Rights Reserved
// </copyright>
// <licensed>Distributed under MIT license</licensed>
// <author>David Vanderheyden</author>
//-----------------------------------------------------------------------

namespace CAPIEH.Core.Models
{
    using System;
    using System.Net;

    /// <summary>
    /// Response for API request success.
    /// </summary>
    /// <typeparam name="TOutputType">Type of the OutputType.</typeparam>
    [Serializable]
    public sealed class DataResponse<TOutputType>
    {/// <summary>
     /// Initializes a new instance of the <see cref="DataResponse{TOutputType}"/> class.
     /// </summary>
     /// <param name="outputType">Generic outputType.</param>
     /// <param name="status">    Status of the Response. Default OK.</param>
        public DataResponse(
            TOutputType outputType,
            ApiResponseStatus status = ApiResponseStatus.Ok)
        {
            Data = outputType;
            Status = status.ToString();
            StatusCode = HttpStatusCode.OK;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataResponse{TOutputType}"/> class.
        /// </summary>
        /// <param name="outputType">Generic outputType.</param>
        /// <param name="statusCode">StatusCode of the response.</param>
        /// <param name="status">    The status of the Response. Default OK.</param>
        public DataResponse(
            TOutputType outputType,
            HttpStatusCode statusCode,
            ApiResponseStatus status = ApiResponseStatus.Ok)
        {
            Data = outputType;
            Status = status.ToString();
            StatusCode = statusCode;
        }

        /// <summary>
        /// Gets the Data Response data.
        /// </summary>
        public TOutputType Data { get; }

        /// <summary>
        /// Gets the Status Flag is by default set to <see cref="ApiResponseStatus.Ok"/>.
        /// </summary>
        public string Status { get; }

        /// <summary>
        /// Gets the StatusCode The <see cref="HttpStatusCode"/>.
        /// </summary>
        public HttpStatusCode StatusCode { get; }

        /// <summary>
        /// Gets a apiResponse to return.
        /// </summary>
        /// <returns>A composed API response model  <see cref="ApiResponse{TOutputType}"/>.</returns>
        public ApiResponse<TOutputType> GetApiResponse()
            => new ApiResponse<TOutputType>(this);
    }
}
