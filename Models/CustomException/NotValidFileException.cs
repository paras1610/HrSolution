using System.Runtime.Serialization;

namespace MyFirstWebAPI.Models.CustomException
{
    [Serializable]
    internal class NotValidFileException : Exception
    {
        public NotValidFileException()
        {
        }

        public NotValidFileException(string? message) : base(message)
        {
        }

        public NotValidFileException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected NotValidFileException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}