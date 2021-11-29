namespace CAPIEH
{
    using System;

    /// <summary>
    /// Details of an API error.
    /// </summary>
    [Serializable]
    public class ErrorInfo
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorInfo" /> class.
        /// </summary>
        /// <param name="type">General error type.</param>
        /// <param name="id">Identifier of the error.</param>
        /// <param name="message">General error message.</param>
        /// <param name="info">Error information and details.</param>
        /// <param name="code">General code used for frontend translations.</param>
        public ErrorInfo(string type, Guid id, string message = null, object info = null, string code = null)
        {
            Type = type;
            Id = (id == Guid.Empty) ? string.Empty : id.ToString();
            Message = message;
            Info = info;
            Code = code;
        }

        /// <summary>
        /// Gets the Code for the Error.
        /// </summary>
        public string Code { get; private set; }

        /// <summary>
        /// Gets the Id The exception ID, for later retrieval in logging.
        /// </summary>
        public string Id { get; private set; }

        /// <summary>
        /// Gets the Info Additional info about the error.
        /// </summary>
        public object Info { get; private set; }

        /// <summary>
        /// Gets the Message Error message.
        /// </summary>
        public string Message { get; private set; }

        /// <summary>
        /// Gets the Type Error type, mapped from the exception type.
        /// </summary>
        public string Type { get; private set; }
    }
}
