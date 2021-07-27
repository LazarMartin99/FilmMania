using FilmMánia.Database;
using FilmMániaZáróDolgozat.Modell;
using FilmMániaZáróDolgozat.Repository;
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
    public partial class LoginForm : Form
    {
        public static string usernamee;
        public static string useremail;
        public static string useerpassword;
        public static int loginid = 0; 
        private RepositoryMovie Mrepo = new RepositoryMovie();
        public LoginForm()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
            Mrepo.setMovies(Mrepo.getMoviesFromDB());
        }

        private void buttonRegisztráció_Click(object sender, EventArgs e)
        {
            RegisterForm register = new RegisterForm();
            register.Show();
            this.Hide();
        }



        private void buttonBejelentkezes_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string userpassword = textBox2.Text;

            if (username.Equals("") || userpassword.Equals(""))
            {
                MessageBox.Show("Üresen hagyott mező");
            }
            else
            {
                UserLogin ul = new UserLogin(username, userpassword);
              if(ul.loginCheck()==true)
              {
                    loginid = ul.getuserId();
                    usernamee = ul.Username;
                    useremail = ul.Useremail;
                    useerpassword = ul.Userpassword;
                    UserInterface ui = new UserInterface();
                    this.Hide();
                    ui.Show();
              }
              else
              {
                    MessageBox.Show("Hibás bejelentkezés");
              }

            }

        }
        private void txtMessage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals(Convert.ToChar(13)))
            {
                buttonBejelentkezes_Click(sender, e);
            }
        }
         /// <summary>
         /// Bejelentkezés előtt ellenőrzi hogy adminisztrátori felhasználóval kiván-e belépni a használó
         /// </summary>
         /// <param name="sender"></param>
         /// <param name="e"></param>
        private void buttonBejelentkezésAdmin_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string userpassword = textBox2.Text;

            if (username.Equals("admin")&&userpassword.Equals("admin12345"))
            {
                AdminInterface Ai = new AdminInterface();
                Ai.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hibás bejelentkezés az adminisztrációs felületbe");
            }



        }
    }
}
