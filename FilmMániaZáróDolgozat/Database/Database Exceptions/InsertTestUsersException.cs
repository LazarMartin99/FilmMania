using System;
using System.Runtime.Serialization;

namespace FilmMánia.Database
{
    [Serializable]
    internal class InsertTestUsersException : Exception
    {
        public InsertTestUsersException()
        {
        }

        public InsertTestUsersException(string message) : base(message)
        {
        }

        public InsertTestUsersException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InsertTestUsersException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}