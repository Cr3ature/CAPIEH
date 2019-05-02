using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;

namespace CAPIEH
{ 
    public delegate Task ExceptionHandler(HttpContext context, Exception exception, Guid errorId);
}
