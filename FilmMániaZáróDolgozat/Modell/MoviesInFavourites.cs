using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmMániaZáróDolgozat.Modell
{
    class MoviesInFavourites
    {
        string title;
        string rating;
        string genre;
        string year;

        public MoviesInFavourites(string title, string rating, string genre, string year)
        {
            this.title = title;
            this.rating = rating;
            this.genre = genre;
            this.year = year;
        }

        public string Title { get => title; set => title = value; }
        public string Rating { get => rating; set => rating = value; }
        public string Genre { get => genre; set => genre = value; }
        public string Year { get => year; set => year = value; }
    }
}
