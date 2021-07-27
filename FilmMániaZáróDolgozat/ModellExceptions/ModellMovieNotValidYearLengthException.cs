using System;
using System.Runtime.Serialization;

namespace FilmMániaZáróDolgozat.Modell
{
    [Serializable]
    public class ModellMovieNotValidYearLengthException : Exception
    {
        public ModellMovieNotValidYearLengthException()
        {
        }

        public ModellMovieNotValidYearLengthException(string message) : base(message)
        {
        }

        public ModellMovieNotValidYearLengthException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ModellMovieNotValidYearLengthException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}