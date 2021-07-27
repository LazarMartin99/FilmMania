using System;
using System.Runtime.Serialization;

namespace FilmMániaZáróDolgozat.Modell
{
    [Serializable]
    internal class ModellMovieNotValidRatingException : Exception
    {
        public ModellMovieNotValidRatingException()
        {
        }

        public ModellMovieNotValidRatingException(string message) : base(message)
        {
        }

        public ModellMovieNotValidRatingException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ModellMovieNotValidRatingException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}