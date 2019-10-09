//-----------------------------------------------------------------------
// <copyright file="ExceptionMiddleware.cs" company="David Vanderheyden">
//     Copyright (c) 2019 All Rights Reserved
// </copyright>
// <licensed>Distributed under Apache2.0 license</licensed>
// <author>David Vanderheyden</author>
// <date>25/05/2019 11:11:17</date>
//-----------------------------------------------------------------------

namespace CAPIEH
{
    using System;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Http;

    /// <summary>
    /// Defines the <see cref="ExceptionMiddleware"/>.
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
        /// Initializes a new instance of the <see cref="ExceptionMiddleware"/> class.
        /// </summary>
        /// <param name="next">   The next <see cref="RequestDelegate"/>.</param>
        /// <param name="handler">The handler <see cref="ExceptionHandler"/>.</param>
        public ExceptionMiddleware(RequestDelegate next, ExceptionHandler handler)
        {
            _next = next;
            _handler = handler;
        }

        /// <summary>
        /// The InvokeAsync.
        /// </summary>
        /// <param name="httpContext">The httpContext <see cref="HttpContext"/>.</param>
        /// <returns>The <see cref="Task"/>.</returns>
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
