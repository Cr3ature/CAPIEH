namespace CAPIEH
{
    using System;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Http;

    /// <summary>
    /// The ExceptionHandler.
    /// </summary>
    /// <param name="context">The context <see cref="HttpContext" />.</param>
    /// <param name="exception">The exception <see cref="Exception" />.</param>
    /// <param name="errorId">The errorId <see cref="Guid" />.</param>
    /// <returns>The <see cref="Task" />.</returns>
    public delegate Task ExceptionHandler(HttpContext context, Exception exception, Guid errorId);
}
