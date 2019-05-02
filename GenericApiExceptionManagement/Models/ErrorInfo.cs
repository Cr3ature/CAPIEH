using System;

namespace GenericApiExceptionManagement
{
    /// <summary>
    /// Details of an API error.
    /// </summary>
    [Serializable]
    public class ErrorInfo
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="type"></param>
        /// <param name="id"></param>
        /// <param name="message"></param>
        /// <param name="info"></param>
        public ErrorInfo(string type, Guid id, string message = null, object info = null)
        {
            this.Type = type;
            this.Id = (id == Guid.Empty) ? string.Empty : id.ToString();
            this.Message = message;
            this.Info = info;
        }

        /// <summary>
        /// The exception ID, for later retrieval in logging.
        /// </summary>
        public string Id { get; private set; }

        /// <summary>
        ///  Additional info about the error.
        /// </summary>
        public object Info { get; private set; }

        /// <summary>
        /// Error message
        /// </summary>
        public string Message { get; private set; }

        /// <summary>
        /// Error type, mapped from the exception type.
        /// </summary>
        public string Type { get; private set; }
    }
}
