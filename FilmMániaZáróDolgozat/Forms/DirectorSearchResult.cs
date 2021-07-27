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

namespace FilmMániaZáróDolgozat.Forms
{
    public partial class DirectorSearchResult : Form
    {
        private DataTable DirectorDT = new DataTable();
        private RepositoryDirector Drepo = new RepositoryDirector();
        private string ConnectionString;
        Connection cs = new Connection();
        public DirectorSearchResult(string director_name)
        {
            InitializeComponent();
            string query = String.Format("SELECT name, gender, dob FROM rendezo WHERE name LIKE '%" + director_name + "%';");
            ConnectionString = cs.getConnectionString();
            MySqlConnection connection = new MySqlConnection(ConnectionString);
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);

            DataTable data = new DataTable();
            adapter.Fill(data);
            dataGridView1.DataSource = data;
        }

        private void DirectorSearchResult_Load(object sender, EventArgs e)
        {
            settingDataGridView();
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
            dataGridView1.Columns[0].HeaderText = "A Rendező neve";
            dataGridView1.Columns[1].HeaderText = "Neme";
            dataGridView1.Columns[2].HeaderText = "Születési ideje";

        }


        private void dataGridView1_CellContentDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            string value = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            DirectorView dv = new DirectorView(value);
            dv.Show();
            this.Hide();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            DirectorSearch ds = new DirectorSearch();
            this.Hide();
            ds.Show();
        }
    }
}
