using System;
using System.Runtime.Serialization;

namespace FilmMániaZáróDolgozat.Modell
{
    [Serializable]
    internal class ModellDirectorNotValidNameException : Exception
    {
        public ModellDirectorNotValidNameException()
        {
        }

        public ModellDirectorNotValidNameException(string message) : base(message)
        {
        }

        public ModellDirectorNotValidNameException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ModellDirectorNotValidNameException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}