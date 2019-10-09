//-----------------------------------------------------------------------
// <copyright file="ExceptionHandlerDelegate.cs" company="David Vanderheyden">
//     Copyright (c) 2019 All Rights Reserved
// </copyright>
// <licensed>Distributed under Apache2.0 license</licensed>
// <author>David Vanderheyden</author>
// <date>25/05/2019 11:10:50</date>
//-----------------------------------------------------------------------

namespace CAPIEH
{
    using System;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Http;

    /// <summary>
    /// The ExceptionHandler.
    /// </summary>
    /// <param name="context">  The context <see cref="HttpContext"/>.</param>
    /// <param name="exception">The exception <see cref="Exception"/>.</param>
    /// <param name="errorId">  The errorId <see cref="Guid"/>.</param>
    /// <returns>The <see cref="Task"/>.</returns>
    public delegate Task ExceptionHandler(HttpContext context, Exception exception, Guid errorId);
}
