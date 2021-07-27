using System;
using System.Runtime.Serialization;

namespace FilmMániaZáróDolgozat.Modell
{
    [Serializable]
    internal class ModellActorIsValidNameException : Exception
    {
        public ModellActorIsValidNameException()
        {
        }

        public ModellActorIsValidNameException(string message) : base(message)
        {
        }

        public ModellActorIsValidNameException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ModellActorIsValidNameException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}