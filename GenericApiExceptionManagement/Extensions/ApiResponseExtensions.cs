using GenericApiExceptionManagement;
using System.Collections;
using System.Net;

namespace Puratos.PreWeighing.Host.ExceptionManagement
{
    public static class ApiResponseExtensions
    {
        public static ApiResponse<TOutput> ToResponse<TOutput>(this TOutput outputType, ApiResponseStatus status = ApiResponseStatus.Ok)
        {
            if (outputType is IEnumerable || typeof(TOutput).IsArray)
            {
                return new ApiResponse<TOutput>(outputType, status);
            }
            return outputType != null
                ? new ApiResponse<TOutput>(outputType, status)
                : throw new DataEntityNotFoundException();
        }

        public static ApiResponse<TOutput> ToResponse<TOutput>(this TOutput outputType, string notFoundMessage, ApiResponseStatus status = ApiResponseStatus.Ok)
        {
            if (outputType is IEnumerable || typeof(TOutput).IsArray)
            {
                return new ApiResponse<TOutput>(outputType, status);
            }
            return outputType != null
                ? new ApiResponse<TOutput>(outputType, status)
                : throw new DataEntityNotFoundException(message: notFoundMessage);
        }

        public static ApiResponse<TOutput> ToResponse<TOutput>(this TOutput outputType, HttpStatusCode statusCode, ApiResponseStatus status = ApiResponseStatus.Ok)
        {
            if (outputType is IEnumerable || typeof(TOutput).IsArray)
            {
                return new ApiResponse<TOutput>(outputType, statusCode, status);
            }
            return outputType != null
                ? new ApiResponse<TOutput>(outputType, statusCode, status)
                : throw new DataEntityNotFoundException();
        }

        public static ApiResponse<TOutput> ToResponse<TOutput>(this TOutput outputType, HttpStatusCode statusCode, string notFoundMessage, ApiResponseStatus status = ApiResponseStatus.Ok)
        {
            if (outputType is IEnumerable || typeof(TOutput).IsArray)
            {
                return new ApiResponse<TOutput>(outputType, statusCode, status);
            }
            return outputType != null
                ? new ApiResponse<TOutput>(outputType, statusCode, status)
                : throw new DataEntityNotFoundException(message: notFoundMessage);
        }
    }
}
