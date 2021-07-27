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
    class RepositoryActor
    {
        private string ConnectionString;
        Connection cs = new Connection();

        /// <summary>
        /// Adatfeltöltésnél kitudja választani a comboboxból az admin a szinész nemét!
        /// </summary>

        List<string> gender = new List<string>() { "Férfi", "Nő" };

        List<Actor> actors;

        public List<string> getGender()
        {
            return gender;
        }

        /// <summary>
        /// Szinész lista deklarálása
        /// </summary>

        public RepositoryActor()
        {
            actors = new List<Actor>();
        }

        public List<Actor> getActors()
        {
            return actors;
        }

        public void setActors(List<Actor> actors)
        {
            this.actors = actors;
        }

        /// <summary>
        /// getAdattáblábaAListából metódus
        /// Adattáblába veszem fel a szinészek különböző adait a listából!
        /// </summary>
        /// <returns></returns>
        public DataTable getActorDataTableFromList()
        {
            DataTable ActorDT = new DataTable();
            ActorDT.Columns.Add("Név", typeof(string));
            ActorDT.Columns.Add("Neme", typeof(string));
            ActorDT.Columns.Add("Születési év", typeof(string));

            foreach (Actor a in actors)
            {
                ActorDT.Rows.Add(a.getActorName(), a.getActorGender(), a.getActorBirth());
            }
            return ActorDT;
        }

        /// <summary>
        /// getSzinészekAzAdatbázisból metódus.
        /// Lekérem az adatokat az adatbázisból és azt a szinész listához adom!
        /// </summary>
        /// <returns></returns>

        public List<Actor> getActorsFromDB()
        {
            ConnectionString = cs.getConnectionString();
            MySqlConnection connection = new MySqlConnection(ConnectionString);
            try
            {
                connection.Open();
                string query = "SELECT * FROM actor";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    int actorid = Convert.ToInt32(dr["actorId"]);
                    string actorname = dr["actor_name"].ToString();
                    string actorgender = dr["gender"].ToString();
                    string actorbirth = dr["dob"].ToString();
                    string actorabout = dr["about"].ToString(); ;
                    string actorimg = dr["image"].ToString(); ;
                    Actor a = new Actor(actorid, actorname, actorgender, actorbirth, actorabout, actorimg);
                    actors.Add(a);

                }
                connection.Close();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message);
                throw new RepositoryException("Szinészek beolvasása az adatbázisból nem sikerült");
            }
            return actors;
        }

        /// <summary>
        /// ÚjszinészhozzáadásAListához metódus.
        /// Új szinész add hozzá a listához adatfeltöltéshez!
        /// </summary>
        /// <param name="newActor"></param>
        public void addActorToList(Actor newActor)
        {
            try
            {
                actors.Add(newActor);
            }
            catch (Exception ex)
            {

                throw new RepositoryException("Szinész hozzáadása nem sikerült!");
            }
        }


        /// <summary>
        /// Insert database metódus.
        /// Az újonnan felvett szinészeket a listában feltölti az adatbázisba!
        /// </summary>
        /// <param name="newActor"></param>

        public void insertActorToDatabase(Actor newActor)
        {
            MySqlConnection connection = new MySqlConnection(ConnectionString);
            try
            {
                connection.Open();
                string query = newActor.getInsert();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {

                connection.Close();
                Debug.WriteLine(ex.Message);
                Debug.WriteLine(newActor + " Szinész beszúrása adatbázisba nem sikerült.");
                throw new RepositoryException("Sikertelen beszúrás az adatbázisba.");

            }
        }


        /// <summary>
        /// Get ID metódus.
        /// Megkeresi a szinész ID-ját a neve alapján!
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>

        public int getActorID(string name)
        {
            return actors.Find(x => x.Actorname == name).Actorid;
        }

        /// <summary>
        /// GetSzinészNeve metódus.
        /// Kikeresi a Szinész listából a szinészek neveit majd azt egy külön listához hozzáadja
        /// </summary>
        /// <returns></returns>

        public List<string> getActorName()
        {
            List<string> name = new List<string>();
            foreach (Actor a in actors)
            {
                name.Add(a.Actorname);
            }
            return name;
        }
    }
}
