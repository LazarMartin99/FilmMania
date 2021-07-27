using FilmMánia.Database;
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
    public partial class MovieSearch : Form
    {
        private string ConnectionString;
        Connection cs = new Connection();
        public MovieSearch()
        {
            InitializeComponent();
        }





        private void button1_Click(object sender, EventArgs e)
        {
            UserInterface ui = new UserInterface();
            this.Hide();
            ui.Show();
        }

        /// <summary>
        /// SQL lekérdezés a film adott szempontjai alapján
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSearch_Click(object sender, EventArgs e)
        {


            int count = 0;
            string query = "SELECT title, name, actor_name, rating, genre FROM movie INNER JOIN rendezo on movie.directorId = rendezo.directorId " +
                "INNER JOIN movie_actor on movie_actor.movie_id = movie.movieId " +
                "INNER JOIN actor on actor.actorId = movie_actor.actor_id ";

            if (textBoxTitle.Text != "")
            {
                query += "WHERE ";
                query += "title LIKE '%" + textBoxTitle.Text + "%' ";
                count++;
            }
            if (textBoxCategory.Text != "")
            {
                if (count != 0)
                {
                    query += "AND ";
                }
                else
                {

                    query += "WHERE ";

                }
                query += "genre LIKE '%" + textBoxCategory.Text + "%' ";
                count++;
            }
            if (textBoxDirector.Text != "")
            {
                if (count != 0)
                {
                    query += "AND ";
                }
                else
                {

                    query += "WHERE ";

                }
                query += " name LIKE '%" + textBoxDirector.Text + "%' ";
                count++;
            }
            if (textBoxActor.Text != "")
            {
                if (count != 0)
                {
                    query += "AND ";
                }
                else
                {

                    query += "WHERE ";

                }
                query += " actor_name LIKE '%" + textBoxActor.Text + "%' ";
                count++;
            }

            query += ";";

            MovieSearchResult movies = new MovieSearchResult(query);
            movies.Show();
            this.Hide();

        }
    }
}
