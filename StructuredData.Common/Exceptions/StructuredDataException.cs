using System;
using System.Runtime.Serialization;

namespace StructuredData.Common.Exceptions
{
    [Serializable]
    public class StructuredDataException : Exception
    {
        public StructuredDataException()
        {
        }

        public StructuredDataException(string message) : base(message)
        {
        }

        public StructuredDataException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected StructuredDataException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}