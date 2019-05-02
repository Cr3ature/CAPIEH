using System;

namespace CAPIEH
{
    [Serializable]
    public class DataEntityNotFoundException : Exception
    {
        public DataEntityNotFoundException()
        {
        }

        public DataEntityNotFoundException(string message) : base(message)
        {
        }

        public DataEntityNotFoundException(string message, Exception inner) : base(message, inner)
        {
        }

        protected DataEntityNotFoundException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
