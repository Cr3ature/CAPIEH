using System;
using System.Collections.Generic;
using System.Text;

namespace CAPIEH.Models
{
    public static class CapiehEnums
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

        /// <summary>
        /// Defines the ApiResponseStatus.
        /// </summary>
        public enum ApiResponseStatus
        {
            /// <summary>
            /// Defines the Ok.
            /// </summary>
            Ok,

            /// <summary>
            /// Defines the NotOk.
            /// </summary>
            NotOk,
        }
    }
}
