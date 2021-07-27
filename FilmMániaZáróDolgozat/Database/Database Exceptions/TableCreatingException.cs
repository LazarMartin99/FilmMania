using System;
using System.Runtime.Serialization;

namespace FilmMánia.Database
{
    [Serializable]
    internal class TableCreatingException : Exception
    {
        public TableCreatingException()
        {
        }

        public TableCreatingException(string message) : base(message)
        {
        }

        public TableCreatingException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected TableCreatingException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}