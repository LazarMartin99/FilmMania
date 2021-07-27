using System;
using System.Runtime.Serialization;

namespace FilmMániaZáróDolgozat.Modell
{
    [Serializable]
    internal class ModellMovieNotValidYearException : Exception
    {
        public ModellMovieNotValidYearException()
        {
        }

        public ModellMovieNotValidYearException(string message) : base(message)
        {
        }

        public ModellMovieNotValidYearException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ModellMovieNotValidYearException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}