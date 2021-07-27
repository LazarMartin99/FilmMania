using System;
using System.Runtime.Serialization;

namespace FilmMániaZáróDolgozat.Modell
{
    [Serializable]
    public class ModellMovieNotValidYearAllCharIsNumber : Exception
    {
        public ModellMovieNotValidYearAllCharIsNumber()
        {
        }

        public ModellMovieNotValidYearAllCharIsNumber(string message) : base(message)
        {
        }

        public ModellMovieNotValidYearAllCharIsNumber(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ModellMovieNotValidYearAllCharIsNumber(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}