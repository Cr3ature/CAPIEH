using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CAPIEH
{
    public static class ExceptionManagementApplciationBuilderExtensions
    {
        public static IApplicationBuilder UseCAPIEH(this IApplicationBuilder app, ExceptionHandler handler)
        {

            app.UseMiddleware<ExceptionMiddleware>(handler);

            return app;
        }
    }
}
