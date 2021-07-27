using System;
using System.Runtime.Serialization;

namespace FilmMániaZáróDolgozat.Modell
{
    [Serializable]
    public class ModellMovieNotValidYearNotMoreThan1850 : Exception
    {
        public ModellMovieNotValidYearNotMoreThan1850()
        {
        }

        public ModellMovieNotValidYearNotMoreThan1850(string message) : base(message)
        {
        }

        public ModellMovieNotValidYearNotMoreThan1850(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ModellMovieNotValidYearNotMoreThan1850(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}