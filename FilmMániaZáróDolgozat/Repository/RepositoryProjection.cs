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
    class RepositoryProjection
    {
        List<string> time = new List<string>() { "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00", "18:00", "19:00", "20:00", "21:00", "22:00"};

        public List<string> getTime()
        {
            return time;
        }

        private string ConnectionString;
        Connection cs = new Connection();
        List<Projection> vetites;

        public RepositoryProjection()
        {


            vetites = new List<Projection>();

        }

        public void setProjection(List<Projection> vetites)
        {
            this.vetites = vetites;
        }

        public List<Projection> getProjection()
        {
            return vetites;
        }

        public List<Projection> getProjectionFromDB()
        {
            ConnectionString = cs.getConnectionString();
            MySqlConnection connection = new MySqlConnection(ConnectionString);
            try
            {
                connection.Open();
                string query = "SELECT * FROM projection";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    int projectionid = Convert.ToInt32(dr["projectionId"]);
                    int movieid = Convert.ToInt32(dr["movie_id"]);
                    string date = dr["date"].ToString();
                    string time = dr["time"].ToString();
                    string price = dr["price"].ToString();

                    Projection p = new Projection(projectionid,date,time,price);
                    vetites.Add(p);

                }
                connection.Close();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message);
                throw new RepositoryException("Vetités beolvasása nem sikerült az adatbázisból!");
            }
            return vetites;
        }



        public void addProjectioneToList(Projection newProjection)
        {
            try
            {
                vetites.Add(newProjection);
            }
            catch (Exception ex)
            {

                throw new RepositoryException("Új vetités hozzáadása nem sikerült!");
            }
        }



        /*public bool favlist(int movieid, int userid)
        {
            List<Favourites> fav = kedvencek.FindAll(x => x.Movieid == movieid);
            foreach (Favourites f in fav)
            {
                if (f.Userid == userid)
                {
                    return true;
                }
            }
            return false;
        }*/



        public void addProjectionToDatabase(Projection newProjection)
        {
            MySqlConnection connection = new MySqlConnection(ConnectionString);
            try
            {
                connection.Open();
                string query = newProjection.InsertInto();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {

                connection.Close();
                Debug.WriteLine(ex.Message);
                Debug.WriteLine(newProjection + " új vetités beszúrása adatbázisba nem sikerült.");
                throw new RepositoryException("Sikertelen beszúrás az adatbázisba.");

            }


        }


    }
}
