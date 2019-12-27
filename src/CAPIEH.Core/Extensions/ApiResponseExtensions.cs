//-----------------------------------------------------------------------
// <copyright file="ApiResponseExtensions.cs" company="David Vanderheyden">
//     Copyright (c) 2019 All Rights Reserved
// </copyright>
// <licensed>Distributed under Apache2.0 license</licensed>
// <author>David Vanderheyden</author>
// <date>25/05/2019 11:11:08</date>
//-----------------------------------------------------------------------

namespace CAPIEH.Core.Extensions
{
    using System.Collections;
    using System.Net;
    using CAPIEH;

    /// <summary>
    /// Defines the <see cref="ApiResponseExtensions"/>.
    /// </summary>
    public static class ApiResponseExtensions
    {
        /// <summary>
        /// The ToResponse.
        /// </summary>
        /// <typeparam name="TOutput">.</typeparam>
        /// <param name="outputType">The outputType <see cref="TOutput"/>.</param>
        /// <param name="status">    The status <see cref="ApiResponseStatus"/>.</param>
        /// <returns>The <see cref="ApiResponse{TOutput}"/>.</returns>
        public static ApiResponse<TOutput> ToResponse<TOutput>(this TOutput outputType, ApiResponseStatus status = ApiResponseStatus.Ok)
        {
            if (outputType is IEnumerable || typeof(TOutput).IsArray)
                return new ApiResponse<TOutput>(outputType, status);

            return outputType != null
                ? new ApiResponse<TOutput>(outputType, status)
                : throw new DataEntityNotFoundException();
        }

        /// <summary>
        /// The ToResponse.
        /// </summary>
        /// <typeparam name="TOutput">.</typeparam>
        /// <param name="outputType">The outputType <see cref="TOutput"/>.</param>
        /// <param name="statusCode">The statusCode <see cref="HttpStatusCode"/>.</param>
        /// <param name="status">    The status <see cref="ApiResponseStatus"/>.</param>
        /// <returns>The <see cref="ApiResponse{TOutput}"/>.</returns>
        public static ApiResponse<TOutput> ToResponse<TOutput>(this TOutput outputType, HttpStatusCode statusCode, ApiResponseStatus status = ApiResponseStatus.Ok)
        {
            if (outputType is IEnumerable || typeof(TOutput).IsArray)
                return new ApiResponse<TOutput>(outputType, statusCode, status);

            return outputType != null
                ? new ApiResponse<TOutput>(outputType, statusCode, status)
                : throw new DataEntityNotFoundException();
        }

        /// <summary>
        /// The ToResponse.
        /// </summary>
        /// <typeparam name="TOutput">.</typeparam>
        /// <param name="outputType">     The outputType <see cref="TOutput"/>.</param>
        /// <param name="statusCode">     The statusCode <see cref="HttpStatusCode"/>.</param>
        /// <param name="notFoundMessage">The notFoundMessage <see cref="string"/>.</param>
        /// <param name="status">         The status <see cref="ApiResponseStatus"/>.</param>
        /// <returns>The <see cref="ApiResponse{TOutput}"/>.</returns>
        public static ApiResponse<TOutput> ToResponse<TOutput>(this TOutput outputType, HttpStatusCode statusCode, string notFoundMessage, ApiResponseStatus status = ApiResponseStatus.Ok)
        {
            if (outputType is IEnumerable || typeof(TOutput).IsArray)
                return new ApiResponse<TOutput>(outputType, statusCode, status);

            return outputType != null
                ? new ApiResponse<TOutput>(outputType, statusCode, status)
                : throw new DataEntityNotFoundException(message: notFoundMessage);
        }

        /// <summary>
        /// The ToResponse.
        /// </summary>
        /// <typeparam name="TOutput">.</typeparam>
        /// <param name="outputType">     The outputType <see cref="TOutput"/>.</param>
        /// <param name="notFoundMessage">The notFoundMessage <see cref="string"/>.</param>
        /// <param name="status">         The status <see cref="ApiResponseStatus"/>.</param>
        /// <returns>The <see cref="ApiResponse{TOutput}"/>.</returns>
        public static ApiResponse<TOutput> ToResponse<TOutput>(this TOutput outputType, string notFoundMessage, ApiResponseStatus status = ApiResponseStatus.Ok)
        {
            if (outputType is IEnumerable || typeof(TOutput).IsArray)
                return new ApiResponse<TOutput>(outputType, status);

            return outputType != null
                ? new ApiResponse<TOutput>(outputType, status)
                : throw new DataEntityNotFoundException(message: notFoundMessage);
        }
    }
}
