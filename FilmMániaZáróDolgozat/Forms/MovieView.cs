using FilmMánia.Database;
using FilmMániaZáróDolgozat.Modell;
using FilmMániaZáróDolgozat.Repository;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmMániaZáróDolgozat
{
    public partial class MovieView : Form
    {
        int movie_id;

        private string ConnectionString;

        Connection cs = new Connection();

        RepositoryFavourites frepo = new RepositoryFavourites();

        /// <summary>
        /// SQL beolvasással megjeleniti az adatok a form megjelenésekor
        /// </summary>
        /// <param name="movie_name"></param>

        public MovieView(string movie_name)
        {
            InitializeComponent();
            frepo.setFavourites(frepo.getFavouritesFromDB());
            label8.Visible = false;
            ConnectionString = cs.getConnectionString();
            MySqlConnection connection = new MySqlConnection(ConnectionString);

            connection.Open();
            MySqlCommand command = connection.CreateCommand();
            string query = "SELECT * FROM movie WHERE title LIKE '%" + movie_name + "%';";
            command.CommandText = query;
            movie_id = 1;

            using (var reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    movie_id= int.Parse(reader.GetString(reader.GetOrdinal("movieId")));
                    label7.Text = reader.GetString(reader.GetOrdinal("title"));
                    label5.Text = reader.GetString(reader.GetOrdinal("genre"));
                    textBox1.Text=reader.GetString(reader.GetOrdinal("about"));

                    try
                    {
                        Byte[] byteBLOBData = (byte[])reader["img"];
                        MemoryStream ms = new MemoryStream(byteBLOBData);
                        pictureBox1.Image = Image.FromStream(ms);
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBox1.Size = new Size(300, 300);
                    }
                    catch (Exception e)
                    {
                        Console.Write(e.Message);
                    }
                }

            }
            label8.Text = movie_id.ToString();

            query = "SELECT actor_name FROM movie INNER JOIN movie_actor on movie_actor.movie_id = movie.movieId INNER JOIN actor on actor.actorId = movie_actor.actor_id WHERE movie_id=" + movie_id + ";";
            command.CommandText = query;
            using (var reader = command.ExecuteReader())
            {
                if (reader.Read())
                {

                    string actor = reader.GetString(reader.GetOrdinal("actor_name"));
                    if (label6.Text == "")
                        label6.Text = actor;
                    else
                        label6.Text += ", " + actor;

                }
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserInterface ui = new UserInterface();
            this.Hide();
            ui.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Hozzáadja a kedvencekhez az adott filmet.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            errorProviderKedvencekLista.Clear();

            Favourites fvs = new Favourites(LoginForm.loginid, Convert.ToInt32(label8.Text));
            try
            {
                if(frepo.favlist(Convert.ToInt32(label8.Text), LoginForm.loginid) ==true)
                {
                    errorProviderKedvencekLista.SetError(button1, "A film már hozzá van adva a kedvencekhez!");
                }
                else
                {
                    frepo.addFavouritesToList(fvs);
                    frepo.addFavouritesToDatabase(fvs);
                    MessageBox.Show("Sikeresen hozzáadta a kedvencekhez");
                }
            }
            catch(RepositoryException re)
            {
                errorProviderKedvencekLista.SetError(button1, re.Message);
            }




        }

        private void button3_Click(object sender, EventArgs e)
        {
                System.Diagnostics.Process.Start("http://localhost/FilmM%C3%A1nia");
        }
    }
}
