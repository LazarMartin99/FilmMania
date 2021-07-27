using System;
using System.Runtime.Serialization;

namespace FilmMánia.Database
{
    [Serializable]
    internal class DatabaseCreateException : Exception
    {
        public DatabaseCreateException()
        {
        }

        public DatabaseCreateException(string message) : base(message)
        {
        }

        public DatabaseCreateException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected DatabaseCreateException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}