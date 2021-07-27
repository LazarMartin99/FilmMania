using FilmMániaZáróDolgozat.Modell;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmMániaZáróDolgozat.Repository
{
    class RepositoryMoviesInFavourites
    {

        List<MoviesInFavourites> miv;

        public RepositoryMoviesInFavourites()
        {
            miv = new List<MoviesInFavourites>();
        }

        public void setMoviesInFavourites(List<MoviesInFavourites> miv)
        {
            this.miv = miv;
        }

        public List<MoviesInFavourites> getMoviesInFavourites()
        {
            return miv;
        }

        public List<MoviesInFavourites> getMoviesData(int userid, List<Favourites> kedvencek, List<Movie> movies)
        {
            //Kikeresi a kedvencek listájából azt a filmet amely a felhasználóhoz tartozik és azt beleteszi egy fav listába.
            List<Favourites> fav = kedvencek.FindAll(x => x.Userid == userid);
            //Foreach-el végig megyünk a fav listán 
            foreach (Favourites f in fav)
            {
                // Kikeresi annak a filmnek az adatait id alapján a movies listából.
                Movie m = movies.Find(x => x.Movieid == f.Movieid);
                // mif listához hozzáadja a kedvenc filmek adatit amelyek megjelenitésre kerülnek a felhasználónak.
                MoviesInFavourites mif = new MoviesInFavourites(m.getTitle(), m.getRating(), m.getGenre(), m.getYear());
                miv.Add(mif);
            }
            return miv;
        }

        public DataTable getMoviesInFavouritesDataTableFromList()
        {
            DataTable MoviesInFavDT = new DataTable();
            MoviesInFavDT.Columns.Add("Filmcim", typeof(string));
            MoviesInFavDT.Columns.Add("IMDb", typeof(string));
            MoviesInFavDT.Columns.Add("Kategória", typeof(string));
            MoviesInFavDT.Columns.Add("Évszám", typeof(string));


            foreach (MoviesInFavourites f in miv)
            {
                MoviesInFavDT.Rows.Add(f.Title, f.Rating, f.Genre, f.Year);
            }
            return MoviesInFavDT;
        }





    }
}
