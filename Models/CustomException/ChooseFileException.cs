using System.Runtime.Serialization;

namespace MyFirstWebAPI.Models.CustomException
{
    [Serializable]
    internal class ChooseFileException : Exception
    {
        public ChooseFileException()
        {
        }

        public ChooseFileException(string? message) : base(message)
        {
        }

        public ChooseFileException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected ChooseFileException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}