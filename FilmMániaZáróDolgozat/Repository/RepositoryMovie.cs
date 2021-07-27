using FilmMánia.Database;
using FilmMániaZáróDolgozat.Modell;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmMániaZáróDolgozat.Repository
{
    class RepositoryMovie
    {
        List<string> genre = new List<string>() { "Akció", "Dráma","Horror","Western","Thriller","Krimi","Sc-Fi","Fantasy","Kaland","Életrajzi","Romantikus","Dokumentum", "Háborús", "Családi"};

        public List<string> getGenre()
        {
            return genre;
        }

        private string ConnectionString;
        Connection cs = new Connection();

        List<Movie> movies;
        
        public RepositoryMovie()
        {
            movies = new List<Movie>();
        }

        public List<Movie> getMovies()
        {
            return movies;
        }

        public void setMovies(List<Movie> movies)
        {
            this.movies = movies;
        }

        public DataTable getMovieDataTableFromList()
        {
            DataTable MovieDT = new DataTable();
            MovieDT.Columns.Add("Filmcim", typeof(string));
            MovieDT.Columns.Add("IMDb", typeof(string));
            MovieDT.Columns.Add("Kategória", typeof(string));
            MovieDT.Columns.Add("Évszám", typeof(string));


            foreach (Movie m in movies)
            {
                MovieDT.Rows.Add(m.getTitle(), m.getRating(), m.getGenre(), m.getYear());
            }
            return MovieDT;
        }

        public List<Movie> getMoviesFromDB()
        {
            ConnectionString = cs.getConnectionString();
            MySqlConnection connection = new MySqlConnection(ConnectionString);
            try
            {
                connection.Open();
                string query = "SELECT * FROM movie";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    int movieid = Convert.ToInt32(dr["movieId"]);
                    string title = dr["title"].ToString();
                    string genre = dr["genre"].ToString();
                    int directorid = Convert.ToInt32(dr["directorId"]);
                    string about = dr["about"].ToString();
                    string year = dr["year"].ToString();
                    string rating = dr["rating"].ToString();
                    string img = dr["img"].ToString();
                    Movie m = new Movie(movieid, title, year, genre, directorid, about, rating, img);
                    movies.Add(m);

                }
                connection.Close();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message);
                throw new RepositoryException("Filmek beolvasása az adatbázisból nem sikerült");
            }
            return movies;
        }

        public void addMovieToList(Movie newMovie)
        {
            try
            {
                movies.Add(newMovie);
            }
            catch (Exception ex)
            {

                throw new RepositoryException("Film hozzáadása nem sikerült!");
            }
        }

        public void insertMovieToDatabase(Movie newMovie)
        {
            MySqlConnection connection = new MySqlConnection(ConnectionString);
            try
            {
                connection.Open();
                string query = newMovie.getInsert();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {

                connection.Close();
                Debug.WriteLine(ex.Message);
                Debug.WriteLine(newMovie + " filmek beszúrása adatbázisba nem sikerült.");
                throw new RepositoryException("Sikertelen beszúrás az adatbázisból.");

            }
        }

        public List<string> getMovieName()
        {
            List<string> name = new List<string>();
            foreach (Movie m in movies)
            {
                name.Add(m.Title);
            }
            return name;
        }




    }
}
