namespace CAPIEH
{
    using System;
    using System.Diagnostics;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Http;

    /// <summary>
    /// Defines the <see cref="ExceptionMiddleware" />.
    /// </summary>
    public class ExceptionMiddleware
    {
        /// <summary>
        /// Defines the _handler.
        /// </summary>
        private readonly ExceptionHandler _handler;

        /// <summary>
        /// Defines the _next.
        /// </summary>
        private readonly RequestDelegate _next;

        /// <summary>
        /// Initializes a new instance of the <see cref="ExceptionMiddleware" /> class.
        /// </summary>
        /// <param name="next">The next <see cref="RequestDelegate" />.</param>
        /// <param name="handler">The handler <see cref="ExceptionHandler" />.</param>
        public ExceptionMiddleware(RequestDelegate next, ExceptionHandler handler)
        {
            _next = next;
            _handler = handler;
        }

        /// <summary>
        /// Try Catch middleware catching all exceptions with correlation Id for logging and building error responses by the passed ExceptionHandler delegate.
        /// </summary>
        /// <param name="httpContext">The httpContext <see cref="HttpContext" />.</param>
        /// <returns>The <see cref="Task" />.</returns>
        public async Task InvokeAsync(HttpContext httpContext)
        {
            try
            {
                Trace.CorrelationManager.ActivityId = Guid.NewGuid();
                await _next(httpContext);
            }
            catch (Exception ex)
            {
                await _handler?.Invoke(httpContext, ex, Trace.CorrelationManager.ActivityId);
            }
        }
    }
}
