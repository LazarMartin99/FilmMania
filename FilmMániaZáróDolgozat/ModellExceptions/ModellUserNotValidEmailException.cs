using System;
using System.Runtime.Serialization;

namespace FilmMániaZáróDolgozat.Modell
{
    [Serializable]
    internal class ModellUserNotValidEmailException : Exception
    {
        public ModellUserNotValidEmailException()
        {
        }

        public ModellUserNotValidEmailException(string message) : base(message)
        {
        }

        public ModellUserNotValidEmailException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ModellUserNotValidEmailException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}