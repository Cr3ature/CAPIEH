//-----------------------------------------------------------------------
// <copyright file="ErrorType.cs" company="David Vanderheyden">
//     Copyright (c) 2020 All Rights Reserved
// </copyright>
// <licensed>Distributed under MIT license</licensed>
// <author>David Vanderheyden</author>
//-----------------------------------------------------------------------

namespace CAPIEH
{
    /// <summary>
    /// Supported error types.
    /// </summary>
    public enum ErrorType
    {
        /// <summary>
        /// Defines the ApplicationError.
        /// </summary>
        ApplicationError,

        /// <summary>
        /// Defines the TechnicalError.
        /// </summary>
        TechnicalError,

        /// <summary>
        /// Defines the BusinessError.
        /// </summary>
        BusinessError,

        /// <summary>
        /// Defines the ResourceError.
        /// </summary>
        ResourceError,

        /// <summary>
        /// Defines the ValidationError.
        /// </summary>
        ValidationError,
    }
}
