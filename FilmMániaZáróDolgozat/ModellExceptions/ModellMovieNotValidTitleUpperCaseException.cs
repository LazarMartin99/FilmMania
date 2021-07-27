using System;
using System.Runtime.Serialization;

namespace FilmMániaZáróDolgozat.Modell
{
    [Serializable]
    public class ModellMovieNotValidTitleUpperCaseException : Exception
    {
        public ModellMovieNotValidTitleUpperCaseException()
        {
        }

        public ModellMovieNotValidTitleUpperCaseException(string message) : base(message)
        {
        }

        public ModellMovieNotValidTitleUpperCaseException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ModellMovieNotValidTitleUpperCaseException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}