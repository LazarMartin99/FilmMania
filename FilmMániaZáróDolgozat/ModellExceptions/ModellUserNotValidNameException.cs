using System;
using System.Runtime.Serialization;

namespace FilmMániaZáróDolgozat.Modell
{
    [Serializable]
    internal class ModellUserNotValidNameException : Exception
    {
        public ModellUserNotValidNameException()
        {
        }

        public ModellUserNotValidNameException(string message) : base(message)
        {
        }

        public ModellUserNotValidNameException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ModellUserNotValidNameException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}