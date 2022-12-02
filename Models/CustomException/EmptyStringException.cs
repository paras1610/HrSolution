using System.Runtime.Serialization;

namespace MyFirstWebAPI.Models.CustomException
{
    [Serializable]
    internal class EmptyStringException : Exception
    {
        private object processedData;

        public EmptyStringException()
        {
        }

        public EmptyStringException(object processedData)
        {
            this.processedData = processedData;
        }

        public EmptyStringException(string? message) : base(message)
        {
        }

        public EmptyStringException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected EmptyStringException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}