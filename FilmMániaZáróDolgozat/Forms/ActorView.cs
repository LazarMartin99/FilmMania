using FilmMánia.Database;
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

namespace FilmMániaZáróDolgozat.Forms
{
    public partial class ActorView : Form
    {
        private string ConnectionString;
        Connection cs = new Connection();
        private RepositoryActor Arepo = new RepositoryActor();



        public ActorView(string actor_name)
        {
            InitializeComponent();
            ConnectionString = cs.getConnectionString();
            MySqlConnection connection = new MySqlConnection(ConnectionString);
            connection.Open();
            string actor_id = "";
            MySqlCommand command = connection.CreateCommand();
            string query = "SELECT * FROM actor WHERE actor_name LIKE '%" + actor_name + "%';";
            command.CommandText = query;
            // MessageBox.Show(query);
            //command.ExecuteReader();
            using (var reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    labelGender.Text = reader.GetString(reader.GetOrdinal("gender"));
                    richTextBox1.Text = reader.GetString(reader.GetOrdinal("about"));
                    labelName.Text = reader.GetString(reader.GetOrdinal("actor_name"));
                    labelDOB.Text = reader.GetString(reader.GetOrdinal("dob"));
                    actor_id = reader.GetString(reader.GetOrdinal("actorId"));

                    try
                    {
                        Byte[] byteBLOBData = (byte[])reader["image"];
                        MemoryStream ms = new MemoryStream(byteBLOBData);
                        pictureBox1.Image = Image.FromStream(ms);
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBox1.Size = new Size(200, 200);
                    }
                    catch (Exception e)
                    {
                        Console.Write(e.Message);
                    }

                }
            }

            query = String.Format(" SELECT  title, avg(rating) FROM movie INNER JOIN movie_actor on movie_actor.movie_id = movie.movieId INNER JOIN actor on actor.actorId = movie_actor.actor_id  WHERE actorId = " + actor_id + " GROUP BY movie_id, title;");
            command = new MySqlCommand(query, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);


            DataTable data = new DataTable();
            adapter.Fill(data);
            dataGridView1.DataSource = data;
            settingDataGridView();

        }


        private void ActorView_Load(object sender, EventArgs e)
        {

        }



        private void settingDataGridView()
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.MultiSelect = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.DefaultCellStyle.Font = new Font("Century Gothic", 8);
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.DeepSkyBlue;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Columns[0].HeaderText = "Filmek amelyekben szerepelt";
            dataGridView1.Columns[1].HeaderText = "IMDb pontszám";

        }

        private void buttonBackToUI_Click(object sender, EventArgs e)
        {
            UserInterface ui = new UserInterface();
            this.Hide();
            ui.Show();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            ActorSearch asearch = new ActorSearch();
            asearch.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string value = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            MovieView mw = new MovieView(value);
            this.Hide();
            mw.Show();
        }
    }
}
