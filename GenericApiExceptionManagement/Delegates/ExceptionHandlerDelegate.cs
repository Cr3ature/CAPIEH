using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;

namespace GenericApiExceptionManagement
{ 
    public delegate Task ExceptionHandler(HttpContext context, Exception exception, Guid errorId);
}
