using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenericApiExceptionManagement
{
    public static class ExceptionManagementApplciationBuilderExtensions
    {
        public static IApplicationBuilder UseApiExceptionHandling(this IApplicationBuilder app, ExceptionHandler handler)
        {

            app.UseMiddleware<ExceptionMiddleware>(handler);

            return app;
        }
    }
}
