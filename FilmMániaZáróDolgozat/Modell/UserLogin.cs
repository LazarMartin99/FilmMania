using FilmMánia.Database;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmMániaZáróDolgozat.Modell
{
    partial class UserLogin
    {
        private string ConnectionString;
        Connection cs = new Connection();
        private string username;
        private string userpassword;
        private string useremail;
        private int userid;

        public UserLogin(string username, string userpassword)
        {
            this.username = username;
            this.userpassword = userpassword;
        }

        public string Username { get => username; set => username = value; }
        public string Userpassword { get => userpassword; set => userpassword = value; }
        public string Useremail { get => useremail; set => useremail = value; }

        public int getuserId()
        {

            return userid;

        }

        /// <summary>
        /// Megnézi hogy a felhasználó által adott adatok egyeznek-e az adatbázisban lévővel
        /// </summary>
        /// <returns></returns>
        public bool loginCheck()
        {
            ConnectionString = cs.getConnectionString();
            
            MySqlConnection con = new MySqlConnection(ConnectionString);
            con.Open();
            string query = "SELECT * FROM login WHERE username = '" + username + "' AND userpassword = '" + userpassword + "'; ";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MySqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                userid = Convert.ToInt32(dr["userId"]);
                username = Convert.ToString(dr["userpassword"]);
                userpassword = Convert.ToString(dr["userpassword"]);
                useremail = Convert.ToString(dr["useremail"]);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
