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
    class RepositoryDirector
    {
        private string ConnectionString;
        Connection cs = new Connection();
        /// <summary>
        /// Adatfeltöltésnél az admin kiválasztja ebből a listából a rendező nevét
        /// </summary>
        List<string> gender = new List<string>() { "Férfi","Nő" };

        List<Director> directors;

        public List<string> getGender()
        {
            return gender;
        }


        /// <summary>
        /// Rendezők listájának deklarása
        /// </summary>
        public RepositoryDirector()
        {
            directors = new List<Director>();
        }

        public List<Director> getDirectors()
        {
            return directors;
        }

        public void setDirectors(List<Director> directors)
        {
            this.directors = directors;
        }


        /// <summary>
        /// getRendezőkAdattáblábaListából metódus
        /// A rendezőket a listából kiszedi és egy adattáblába teszi a megadott szempontok alapján.
        /// </summary>
        /// <returns></returns>
        public DataTable getDirectorDataTableFromList()
        {
            DataTable DirectorDT = new DataTable();
            DirectorDT.Columns.Add("Név", typeof(string));
            DirectorDT.Columns.Add("Neme", typeof(string));
            DirectorDT.Columns.Add("Születési év", typeof(string));

            foreach (Director d in directors)
            {
                DirectorDT.Rows.Add(d.getDirectorName(), d.getDirectorGender(), d.getDirectorBirth());
            }
            return DirectorDT;         
        }



        /// <summary>
        /// getRendezőkAdatbázisból metódus
        /// Rendezőket lekéri az adatbázisból és hozzáadja a rendezők listához
        /// </summary>
        /// <returns></returns>

        public List<Director> getDirectorsFromDB()
        {
            ConnectionString = cs.getConnectionString();
            MySqlConnection connection = new MySqlConnection(ConnectionString);
            try
            {
                connection.Open();
                string query = "SELECT * FROM rendezo";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    int directorid = Convert.ToInt32(dr["directorId"]);
                    string directorname = dr["name"].ToString();
                    string directorgender = dr["gender"].ToString();
                    string directorbirth = dr["dob"].ToString();
                    string directorabout = dr["about"].ToString();;
                    string directorimg = dr["image"].ToString();;
                    Director d = new Director(directorid, directorname, directorgender, directorbirth, directorabout, directorimg);
                    directors.Add(d);

                }
                connection.Close();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message);
                throw new RepositoryException("Rendezők beolvasása az adatbázisból nem sikerült");
            }
            return directors;
        }

        /// <summary>
        /// újRendezőhozzáadásListához metódus
        /// Új rendezőt ad hozzá a listához adatfeltöltésnél
        /// </summary>
        /// <param name="newDirector"></param>
        public void addDirectorToList(Director newDirector)
        {
            try
            {
                directors.Add(newDirector);
            }
            catch (Exception ex)
            {

                throw new RepositoryException("Rendező hozzáadása nem sikerült!");
            }
        }

        /// <summary>
        /// Az újonnan hozzáadott rendezőket hozzáadja az adatbázishoz
        /// </summary>
        /// <param name="newDirector"></param>
        public void insertDirectorToDatabase(Director newDirector)
        {
            MySqlConnection connection = new MySqlConnection(ConnectionString);
            try
            {
                connection.Open();
                string query = newDirector.getInsert();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {

                connection.Close();
                Debug.WriteLine(ex.Message);
                Debug.WriteLine(newDirector + " Rendező beszúrása adatbázisba nem sikerült.");
                throw new RepositoryException("Sikertelen beszúrás az adatbázisba.");

            }
        }



        /// <summary>
        /// GetRendezőSorszáma metódus
        /// Megkeresi a rendező sorszámát a neve alapján
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public int getDirectorID(string name)
        {
            return directors.Find(x => x.Directorname == name).Directorid;
        }

        /// <summary>
        /// getRendezőkNevei
        /// Rendezők listából kikeresi a rendezők nevét majd hozzáadja a nevek listához
        /// </summary>
        /// <returns></returns>
        public List<string> getDirectorName()
        {
            List<string> name = new List<string>();
            foreach (Director d in directors)
            {
                name.Add(d.Directorname);
            }
            return name;
        }
    }
}
