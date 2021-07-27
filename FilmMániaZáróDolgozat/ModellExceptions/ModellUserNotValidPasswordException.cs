using System;
using System.Runtime.Serialization;

namespace FilmMániaZáróDolgozat.Modell
{
    [Serializable]
    internal class ModellUserNotValidPasswordException : Exception
    {
        public ModellUserNotValidPasswordException()
        {
        }

        public ModellUserNotValidPasswordException(string message) : base(message)
        {
        }

        public ModellUserNotValidPasswordException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ModellUserNotValidPasswordException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}