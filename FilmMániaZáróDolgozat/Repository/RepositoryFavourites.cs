using FilmMánia.Database;
using FilmMániaZáróDolgozat.Modell;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmMániaZáróDolgozat.Repository
{
    class RepositoryFavourites
    {
        private string ConnectionString;
        Connection cs = new Connection();
        List<Favourites> kedvencek;

        public RepositoryFavourites()
        {
           kedvencek = new List<Favourites>();
        }

        public void setFavourites(List<Favourites> kedvencek)
        {
            this.kedvencek = kedvencek;
        }

        public List<Favourites> getFavourites()
        {
            return kedvencek;
        }

        public List<Favourites> getFavouritesFromDB()
        {
            ConnectionString = cs.getConnectionString();
            MySqlConnection connection = new MySqlConnection(ConnectionString);
            try
            {
                connection.Open();
                string query = "SELECT * FROM favourites";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    int userid = Convert.ToInt32(dr["user_id"]);
                    int movieid = Convert.ToInt32(dr["movie_id"]);
                    
                    Favourites f = new Favourites(userid, movieid);
                    kedvencek.Add(f);

                }
                connection.Close();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message);
                throw new RepositoryException("Kedvencek beolvasása nem sikerült az adatbázisból!");
            }
            return kedvencek;
        }

        /// <summary>
        /// Kikeresi a kedvenceket a film és a felhasználó azonositója alapján
        /// </summary>
        /// <param name="movieid"></param>
        /// <param name="userid"></param>
        /// <returns></returns>
        public bool favlist(int movieid, int userid)
        {
            List<Favourites> fav = kedvencek.FindAll(x => x.Movieid == movieid);
            foreach (Favourites f in fav)
            {
                if(f.Userid==userid)
                {
                    return true;
                }
            }
            return false;
        }


        public void addFavouritesToList(Favourites newFavourite)
        {
           kedvencek.Add(newFavourite);
        }


        public void addFavouritesToDatabase(Favourites newFavourite)
        {
            MySqlConnection connection = new MySqlConnection(ConnectionString);
            try
            {
                connection.Open();
                string query = newFavourite.InsertInto();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {

                connection.Close();
                Debug.WriteLine(ex.Message);
                Debug.WriteLine(newFavourite + " új Kedvenc beszúrása adatbázisba nem sikerült.");
                throw new RepositoryException("Sikertelen beszúrás az adatbázisból.");

            }


        }



    }
}
