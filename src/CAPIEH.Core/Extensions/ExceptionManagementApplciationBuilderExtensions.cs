namespace CAPIEH
{
    using Microsoft.AspNetCore.Builder;

    /// <summary>
    /// Defines the <see cref="ExceptionManagementApplciationBuilderExtensions" />.
    /// </summary>
    public static class ExceptionManagementApplciationBuilderExtensions
    {
        /// <summary>
        /// The UseCAPIEH.
        /// </summary>
        /// <param name="app">The app <see cref="IApplicationBuilder" />.</param>
        /// <param name="handler">The handler <see cref="ExceptionHandler" />.</param>
        /// <returns>The <see cref="IApplicationBuilder" />.</returns>
        public static IApplicationBuilder UseCAPIEH(this IApplicationBuilder app, ExceptionHandler handler)
        {
            app.UseMiddleware<ExceptionMiddleware>(handler);

            return app;
        }
    }
}
