using FilmMánia.Database;
using FilmMániaZáróDolgozat.Forms;
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
    public partial class UserInterface : Form
    {

        private DataTable MovieDT = new DataTable();
        private DataTable MoviesInFavDT = new DataTable();
        private RepositoryMovie Mrepo = new RepositoryMovie();
        private RepositoryFavourites Frepo = new RepositoryFavourites();
        private RepositoryMoviesInFavourites MIFrepo = new RepositoryMoviesInFavourites();
        private string ConnectionString;
        Connection cs = new Connection();
        public UserInterface()
        {
            InitializeComponent();
            Mrepo.setMovies(Mrepo.getMoviesFromDB());
            Frepo.setFavourites(Frepo.getFavouritesFromDB());
            MIFrepo.setMoviesInFavourites(MIFrepo.getMoviesData(LoginForm.loginid, Frepo.getFavourites(), Mrepo.getMovies()));
        }

        private void UserInterface_Load(object sender, EventArgs e)
        {
            RefreshDatasForDataGridView();
            RefreshDatasForDataGridViewFavourites();
            settingDataGridView();
            settingDataGridViewFavourites();
        }

        private void RefreshDatasForDataGridView()
        {
            dataGridView1.DataSource = null;
            MovieDT = Mrepo.getMovieDataTableFromList();
            dataGridView1.DataSource = MovieDT;
        }

        private void RefreshDatasForDataGridViewFavourites()
        {
            dataGridViewFavourites.DataSource = null;
            MoviesInFavDT = MIFrepo.getMoviesInFavouritesDataTableFromList();
            dataGridViewFavourites.DataSource = MoviesInFavDT;
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
            dataGridView1.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView1.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView1.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView1.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;

        }




        private void settingDataGridViewFavourites()
        {
            dataGridViewFavourites.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewFavourites.ReadOnly = true;
            dataGridViewFavourites.AllowUserToDeleteRows = false;
            dataGridViewFavourites.AllowUserToAddRows = false;
            dataGridViewFavourites.MultiSelect = false;
            dataGridViewFavourites.AllowUserToResizeRows = false;
            dataGridViewFavourites.AllowUserToResizeColumns = false;
            dataGridViewFavourites.EnableHeadersVisualStyles = false;
            dataGridViewFavourites.RowHeadersVisible = false;
            dataGridViewFavourites.DefaultCellStyle.Font = new Font("Century Gothic", 8);
            dataGridViewFavourites.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewFavourites.ColumnHeadersDefaultCellStyle.BackColor = Color.DeepSkyBlue;
            dataGridViewFavourites.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewFavourites.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewFavourites.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewFavourites.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewFavourites.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewFavourites.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
        }







        private void button6_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //string value = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            string value = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            MovieView mw = new MovieView(value);
            this.Hide();
            mw.Show();


        }

        private void buttonProfile_Click(object sender, EventArgs e)
        {
        }

        private void buttonMovie_Click(object sender, EventArgs e)
        {
            MovieSearch ms = new MovieSearch();
            this.Hide();
            ms.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonActor_Click(object sender, EventArgs e)
        {
            ActorSearch asearch = new ActorSearch();
            this.Hide();
            asearch.Show();
        }

        private void buttonDirector_Click(object sender, EventArgs e)
        {
            DirectorSearch ds = new DirectorSearch();
            this.Hide();
            ds.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewFavourites_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string value = dataGridViewFavourites.SelectedRows[0].Cells[0].Value.ToString();
            MovieView mw = new MovieView(value);
            this.Hide();
            mw.Show();
        }
    }
}
