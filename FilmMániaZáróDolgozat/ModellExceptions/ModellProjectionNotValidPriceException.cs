using System;
using System.Runtime.Serialization;

namespace FilmMániaZáróDolgozat.Modell
{
    [Serializable]
    internal class ModellProjectionNotValidPriceException : Exception
    {
        public ModellProjectionNotValidPriceException()
        {
        }

        public ModellProjectionNotValidPriceException(string message) : base(message)
        {
        }

        public ModellProjectionNotValidPriceException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ModellProjectionNotValidPriceException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}