//-----------------------------------------------------------------------
// <copyright file="ErrorResponse.cs" company="David Vanderheyden">
//     Copyright (c) 2020 All Rights Reserved
// </copyright>
// <licensed>Distributed under MIT license</licensed>
// <author>David Vanderheyden</author>
//-----------------------------------------------------------------------

namespace CAPIEH
{
    using System;
    using System.Net;

    /// <summary>
    /// Error response for API request failures.
    /// </summary>
    [Serializable]
    public sealed class ErrorResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorResponse"/> class.
        /// </summary>
        /// <param name="errorType"> General error type.</param>
        /// <param name="errorId">   Identifier of the error.</param>
        /// <param name="message">   General error message.</param>
        /// <param name="info">      Error information and details.</param>
        /// <param name="code">      General code used for frontend translations.</param>
        /// <param name="statusCode">Status code that represents the response.</param>
        public ErrorResponse(ErrorType errorType, HttpStatusCode statusCode, Guid errorId, string message, string code, object info = null)
        {
            StatusCode = statusCode;
            Error = new ErrorInfo(
                type: errorType.ToString(),
                id: errorId,
                message: message,
                info: info,
                code: code);
        }

        /// <summary>
        /// Gets the Error Error details.
        /// </summary>
        public ErrorInfo Error { get; }

        /// <summary>
        /// Gets the Status Flag is always set to <see cref="ApiResponseStatus.NotOk"/>.
        /// </summary>
        public string Status => ApiResponseStatus.NotOk.ToString();

        /// <summary>
        /// Gets the StatusCode The <see cref="HttpStatusCode"/>.
        /// </summary>
        public HttpStatusCode StatusCode { get; }

        /// <summary>
        /// Gets a apiResponse to return.
        /// </summary>
        /// <returns>A composed API response model  <see cref="ApiResponse{Boolean?}"/>.</returns>
        public ApiResponse<bool?> GetApiResponse()
            => new ApiResponse<bool?>(this);
    }
}
