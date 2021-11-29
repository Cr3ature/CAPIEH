namespace CAPIEH
{
    using System;

    /// <summary>
    /// Defines the <see cref="DataEntityNotFoundException" />.
    /// </summary>
    [Serializable]
    public class DataEntityNotFoundException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DataEntityNotFoundException" /> class.
        /// </summary>
        public DataEntityNotFoundException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataEntityNotFoundException" /> class.
        /// </summary>
        /// <param name="message">The message <see cref="string" />.</param>
        public DataEntityNotFoundException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataEntityNotFoundException" /> class.
        /// </summary>
        /// <param name="message">The message <see cref="string" />.</param>
        /// <param name="inner">The inner <see cref="Exception" />.</param>
        public DataEntityNotFoundException(string message, Exception inner)
            : base(message, inner)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataEntityNotFoundException" /> class.
        /// </summary>
        /// <param name="info">
        /// The info <see cref="System.Runtime.Serialization.SerializationInfo" />.
        /// </param>
        /// <param name="context">
        /// The context <see cref="System.Runtime.Serialization.StreamingContext" />.
        /// </param>
        protected DataEntityNotFoundException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context)
        {
        }
    }
}
