using FilmMánia.Database;
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
    public partial class MovieSearchResult : Form
    {
        private DataTable MovieDT = new DataTable();
        private RepositoryMovie Mrepo = new RepositoryMovie();
        private string ConnectionString;
        Connection cs = new Connection();
        public MovieSearchResult(string query)
        {
            InitializeComponent();
           
            ConnectionString = cs.getConnectionString();
            MySqlConnection connection = new MySqlConnection(ConnectionString);
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);

            DataTable data = new DataTable();
            adapter.Fill(data);
            dataGridView1.DataSource = data;
            settingDataGridView();
        }

        /// <summary>
        /// Beállitja a datagridview beállitásait
        /// </summary>

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
            dataGridView1.DefaultCellStyle.Font = new Font("Century Gothic", 8);
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.DeepSkyBlue;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Columns[0].HeaderText = "Film cime";
            dataGridView1.Columns[1].HeaderText = "Rendező neve";
            dataGridView1.Columns[2].HeaderText = "Szinész neve";
            dataGridView1.Columns[3].HeaderText = "IMDb pontszám";
            dataGridView1.Columns[4].HeaderText = "Kategória";


        }

        private void button1_Click(object sender, EventArgs e)
        {
            MovieSearch ms = new MovieSearch();
            ms.Show();
            this.Hide();
        }


        private void dataGridView1_CellContentDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            string value = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            MovieView mw = new MovieView(value);
            this.Hide();
            mw.Show();
        }
    }
}
