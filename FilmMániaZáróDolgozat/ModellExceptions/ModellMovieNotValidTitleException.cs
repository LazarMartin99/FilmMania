using System;
using System.Runtime.Serialization;

namespace FilmMániaZáróDolgozat.Modell
{
    [Serializable]
    internal class ModellMovieNotValidTitleException : Exception
    {
        public ModellMovieNotValidTitleException()
        {
        }

        public ModellMovieNotValidTitleException(string message) : base(message)
        {
        }

        public ModellMovieNotValidTitleException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ModellMovieNotValidTitleException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}