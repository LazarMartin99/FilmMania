using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmMánia.Database
{
    partial class CreateConnections
    {
        private string connectionStringCreate;
        private string connectionString;
        Connection c = new Connection();

        /// <summary>
        /// Film Mánia adatbázis létrehozása
        /// </summary>
        
        public void createDatabase()
        {
            connectionStringCreate = c.getCreateConnectionString();
            MySqlConnection connection = new MySqlConnection(connectionStringCreate);
            try
            {
                connection.Open();
                string query =
                "CREATE DATABASE IF NOT EXISTS filmmania " +
                "DEFAULT CHARACTER SET utf8 " +
                "COLLATE utf8_hungarian_ci ";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message + "*******************************************************************************");
                throw new DatabaseCreateException("Adatbázis létrehozása nem sikerült vagy már létezik.");
            }
        }








        






       


    }
}
