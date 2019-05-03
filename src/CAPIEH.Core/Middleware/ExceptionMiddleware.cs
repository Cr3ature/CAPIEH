using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;

namespace CAPIEH
{
    public class ExceptionMiddleware
    {
        private readonly ExceptionHandler _handler;
        private readonly RequestDelegate _next;

        public ExceptionMiddleware(RequestDelegate next, ExceptionHandler handler)
        {
            _next = next;
            _handler = handler;
        }

        public async Task InvokeAsync(HttpContext httpContext)
        {
            try
            {
                await _next(httpContext);
            }
            catch (Exception ex)
            {
                var errorId = Guid.NewGuid();
                await _handler?.Invoke(httpContext, ex, errorId);
            }
        }
    }
}
