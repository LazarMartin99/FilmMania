using FilmMánia.Database;
using FilmMániaZáróDolgozat.Modell;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmMániaZáróDolgozat
{

    public partial class RegisterForm : Form
    {
        private string ConnectionString;
        Connection cs = new Connection();
        public RegisterForm()
        {
            InitializeComponent();
            ConnectionString = cs.getConnectionString();
        }

        /// <summary>
        /// Regisztráció megfelelő adatokat feltölti az adatbáziba
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            string username = textBoxFelhasznaloReg.Text;
            string userpassword = textBoxJelszoReg.Text;
            string useremail = textBoxEmailReg.Text;
            errorProviderName.Clear();
            errorProviderEmail.Clear();
            errorProviderPassword.Clear();
            MySqlConnection connection = new MySqlConnection(ConnectionString);
            try
            {               
                    connection.Open();
                    MySqlCommand command = connection.CreateCommand();
                    command.CommandText = "INSERT INTO `login`(`username`,`useremail`,`userpassword`) VALUES ('" + username + "','" + useremail + "','" + userpassword + "');";
                    User u = new User(username, useremail, userpassword);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Regisztráció sikeres!");
                    LoginForm login = new LoginForm();
                    login.Show();
                    this.Hide();
                    connection.Close();
            }
            catch(ModellUserNotValidNameException name)
            {
                errorProviderName.SetError(textBoxFelhasznaloReg, name.Message);
                connection.Close();
            }
            catch (ModellUserNotValidEmailException email)
            {             
                errorProviderEmail.SetError(textBoxEmailReg, email.Message);
                connection.Close();
            }
            catch (ModellUserNotValidPasswordException pass)
            {
                errorProviderPassword.SetError(textBoxJelszoReg, pass.Message);
                connection.Close();
            }
        }


        private void buttonBack_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }
    }
    
}
