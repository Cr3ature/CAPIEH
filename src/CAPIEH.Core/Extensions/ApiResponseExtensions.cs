namespace CAPIEH
{
    using System.Collections;
    using System.Net;

    /// <summary>
    /// Defines the <see cref="ApiResponseExtensions" />.
    /// </summary>
    public static class ApiResponseExtensions
    {
        /// <summary>
        /// Converts the outputType to a DataResponse. Null is a valid response.
        /// </summary>
        /// <typeparam name="TOutput">.</typeparam>
        /// <param name="outputType">The outputType <see cref="TOutput" />.</param>
        /// <param name="status">The status <see cref="ApiResponseStatus" />.</param>
        /// <returns>The <see cref="ApiResponse{TOutput}" />.</returns>
        public static ApiResponse<TOutput> ToResponse<TOutput>(
            this TOutput outputType,
            ApiResponseStatus status = ApiResponseStatus.Ok)
        {
            if (outputType is IEnumerable || typeof(TOutput).IsArray)
                return new DataResponse<TOutput>(outputType, status).GetApiResponse();

            return new DataResponse<TOutput>(outputType, status).GetApiResponse();
        }

        /// <summary>
        /// Converts the outputType to a DataResponse. Null is a valid response.
        /// </summary>
        /// <typeparam name="TOutput">.</typeparam>
        /// <param name="outputType">The outputType <see cref="TOutput" />.</param>
        /// <param name="statusCode">The statusCode <see cref="HttpStatusCode" />.</param>
        /// <param name="status">The status <see cref="ApiResponseStatus" />.</param>
        /// <returns>The <see cref="ApiResponse{TOutput}" />.</returns>
        public static ApiResponse<TOutput> ToResponse<TOutput>(
            this TOutput outputType,
            HttpStatusCode statusCode,
            ApiResponseStatus status = ApiResponseStatus.Ok)
        {
            if (outputType is IEnumerable || typeof(TOutput).IsArray)
                return new DataResponse<TOutput>(outputType, statusCode, status).GetApiResponse();

            return new DataResponse<TOutput>(outputType, statusCode, status).GetApiResponse();
        }

        /// <summary>
        /// Converts the outputType to a DataResponse with a null check.
        /// </summary>
        /// <typeparam name="TOutput">.</typeparam>
        /// <param name="outputType">The outputType <see cref="TOutput" />.</param>
        /// <param name="status">The status <see cref="ApiResponseStatus" />.</param>
        /// <returns>The <see cref="ApiResponse{TOutput}" />.</returns>
        public static ApiResponse<TOutput> ToResponseWithNullCheck<TOutput>(
            this TOutput outputType,
            ApiResponseStatus status = ApiResponseStatus.Ok)
        {
            if (outputType is IEnumerable || typeof(TOutput).IsArray)
                return new DataResponse<TOutput>(outputType, status).GetApiResponse();

            return outputType != null
                ? new DataResponse<TOutput>(outputType, status).GetApiResponse()
                : throw new DataEntityNotFoundException();
        }

        /// <summary>
        /// Converts the outputType to a DataResponse with a null check.
        /// </summary>
        /// <typeparam name="TOutput">.</typeparam>
        /// <param name="outputType">The outputType <see cref="TOutput" />.</param>
        /// <param name="statusCode">The statusCode <see cref="HttpStatusCode" />.</param>
        /// <param name="status">The status <see cref="ApiResponseStatus" />.</param>
        /// <returns>The <see cref="ApiResponse{TOutput}" />.</returns>
        public static ApiResponse<TOutput> ToResponseWithNullCheck<TOutput>(
            this TOutput outputType,
            HttpStatusCode statusCode,
            ApiResponseStatus status = ApiResponseStatus.Ok)
        {
            if (outputType is IEnumerable || typeof(TOutput).IsArray)
                return new DataResponse<TOutput>(outputType, statusCode, status).GetApiResponse();

            return outputType != null
                ? new DataResponse<TOutput>(outputType, statusCode, status).GetApiResponse()
                : throw new DataEntityNotFoundException();
        }

        /// <summary>
        /// Converts the outputType to a DataResponse with a null check.
        /// </summary>
        /// <typeparam name="TOutput">.</typeparam>
        /// <param name="outputType">The outputType <see cref="TOutput" />.</param>
        /// <param name="statusCode">The statusCode <see cref="HttpStatusCode" />.</param>
        /// <param name="notFoundMessage">The notFoundMessage <see cref="string" />.</param>
        /// <param name="status">The status <see cref="ApiResponseStatus" />.</param>
        /// <returns>The <see cref="ApiResponse{TOutput}" />.</returns>
        public static ApiResponse<TOutput> ToResponseWithNullCheck<TOutput>(
            this TOutput outputType,
            HttpStatusCode statusCode,
            string notFoundMessage,
            ApiResponseStatus status = ApiResponseStatus.Ok)
        {
            if (outputType is IEnumerable || typeof(TOutput).IsArray)
                return new DataResponse<TOutput>(outputType, statusCode, status).GetApiResponse();

            return outputType != null
                ? new DataResponse<TOutput>(outputType, statusCode, status).GetApiResponse()
                : throw new DataEntityNotFoundException(message: notFoundMessage);
        }

        /// <summary>
        /// Converts the outputType to a DataResponse with a null check.
        /// </summary>
        /// <typeparam name="TOutput">.</typeparam>
        /// <param name="outputType">The outputType <see cref="TOutput" />.</param>
        /// <param name="notFoundMessage">The notFoundMessage <see cref="string" />.</param>
        /// <param name="status">The status <see cref="ApiResponseStatus" />.</param>
        /// <returns>The <see cref="ApiResponse{TOutput}" />.</returns>
        public static ApiResponse<TOutput> ToResponseWithNullCheck<TOutput>(
            this TOutput outputType,
            string notFoundMessage,
            ApiResponseStatus status = ApiResponseStatus.Ok)
        {
            if (outputType is IEnumerable || typeof(TOutput).IsArray)
                return new DataResponse<TOutput>(outputType, status).GetApiResponse();

            return outputType != null
                ? new DataResponse<TOutput>(outputType, status).GetApiResponse()
                : throw new DataEntityNotFoundException(message: notFoundMessage);
        }
    }
}
