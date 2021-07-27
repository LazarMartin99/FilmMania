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
    public partial class AdminInterface : Form
    {
        RepositoryMovie rm = new RepositoryMovie();
        RepositoryDirector rd = new RepositoryDirector();
        RepositoryActor ra = new RepositoryActor();
        RepositoryProjection rp = new RepositoryProjection();
        Connection cs = new Connection();
        private string ConnectionString;

        public AdminInterface()
        {
            InitializeComponent();
            ConnectionString = cs.getConnectionString();
            MySqlConnection connection = new MySqlConnection(ConnectionString);
            MySqlDataReader myReader;
            connection.Open();
            MySqlCommand command = connection.CreateCommand();
            command = new MySqlCommand("SELECT * FROM rendezo", connection);

            dateTimePickerDirector.Format = DateTimePickerFormat.Custom;
            dateTimePickerDirector.CustomFormat = "yyyy/MM/dd";

            dateTimePickerActor.Format = DateTimePickerFormat.Custom;
            dateTimePickerActor.CustomFormat = "yyyy/MM/dd";

            comboBoxRendezo.DataSource = rd.getDirectorName();
            comboBoxMovie.DataSource = rm.getMovieName(); 


        }
        /// <summary>
        /// Feltölt minden comboboxot a repository adatokkal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AdminInterface_Load(object sender, EventArgs e)
        {
            rm.setMovies(rm.getMoviesFromDB());
            rd.setDirectors(rd.getDirectorsFromDB());
            ra.setActors(ra.getActorsFromDB());
            rp.setProjection(rp.getProjectionFromDB());
            comboBoxRendezo.DataSource = rd.getDirectorName();
            comboBoxMovie.DataSource = rm.getMovieName();
            comboBoxMovieProject.DataSource = rm.getMovieName();
            comboBoxKategória.DataSource = rm.getGenre();
            comboBoxTime.DataSource = rp.getTime();
            comboBoxDirectorGender.DataSource = rd.getGender();
            comboBoxGenderActor.DataSource = ra.getGender();
            comboBoxActor.DataSource = ra.getActorName();

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }
        /// <summary>
        /// Filmek képét kikeresi a mappából
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonKep_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.InitialDirectory = "C:\\ProgramData\\MySQL\\MySQL Server 5.7\\Uploads";
            open.Filter = "Image Files (*.jpg)|*.jpg|All Files(*.*)|*.*";
            open.FilterIndex = 1;
            if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (open.CheckFileExists)
                {
                    string pathname = System.IO.Path.GetFullPath(open.FileName);
                    pathname = pathname.Replace("\\", "/");
                    labelKephelye.Text = pathname;
                }
            }
        }

        /// <summary>
        /// Film hozzáadása az adatbázishoz
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>********************************************************************************************************************************************

        private void buttonMovieFeltolt_Click_1(object sender, EventArgs e)
        {
            errorProviderName.Clear();
            errorProviderRating.Clear();
            errorProviderRating.Clear();
            errorProviderYear.Clear();
            try
            {
                MySqlConnection connection = new MySqlConnection(ConnectionString);
                connection.Open();
                MySqlCommand command = connection.CreateCommand();
                int id = rd.getDirectorID(comboBoxRendezo.Text);
                
                Movie newMovie = new Movie(
                    textBoxName.Text,
                    textBoxYear.Text,
                    comboBoxKategória.Text,
                    textBoxRating.Text,
                    labelKephelye.Text,
                    richTextBoxAbout.Text,
                    id
                    ) ;
                if(!newMovie.isValid())
                {
                    return;
                }
                else
                {
                    rm.addMovieToList(newMovie);
                    rm.insertMovieToDatabase(newMovie);
                    MessageBox.Show("Sikeres feltöltés az adatbázisba");
                }
            }
            catch (ModellMovieNotValidTitleException mmnvte)
            {
                errorProviderName.SetError(textBoxName, mmnvte.Message);
            }
            catch (ModellMovieNotValidTitleUpperCaseException mmnvucte)
            {
                errorProviderName.SetError(textBoxName, mmnvucte.Message);
            }
            catch (ModellMovieNotValidYearLengthException mmnvyle)
            {
                errorProviderName.SetError(textBoxYear, mmnvyle.Message);
            }
            catch (ModellMovieNotValidYearAllCharIsNumber mmnvyacin)
            {
                errorProviderName.SetError(textBoxYear, mmnvyacin.Message);
            }
            catch (ModellMovieNotValidYearNotMoreThan1850 mmnvynmt1850)
            {
                errorProviderName.SetError(textBoxYear, mmnvynmt1850.Message);
            }
            catch (ModellMovieNotValidRatingException mmnvre)
            {
                errorProviderRating.SetError(textBoxRating, mmnvre.Message);
            }
        }

        private void comboBoxRendezo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = rd.getDirectorID(comboBoxRendezo.Text);
        }

        /// <summary>
        /// Rendező hozzáadása az adatbázishoz
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>**************************************************************************************************************************************************
        /// 


        private void buttonRendezoFeltolt_Click(object sender, EventArgs e)
        {

            errorProviderDirectorName.Clear();
            try
            {
                MySqlConnection connection = new MySqlConnection(ConnectionString);
                connection.Open();
                MySqlCommand command = connection.CreateCommand();

                Director newDirector = new Director(
                    textBoxDirector.Text,
                    comboBoxDirectorGender.Text,
                    dateTimePickerDirector.Text,
                    richTextBoxDirector.Text,
                    labelKepHelyeDirector.Text
                    );
                rd.addDirectorToList(newDirector);
                rd.insertDirectorToDatabase(newDirector);
                MessageBox.Show("Sikeres feltöltés az adatbázisba");
            }
            catch (ModellMovieNotValidTitleUpperCaseException mmnvte)
            {
                errorProviderDirectorName.SetError(textBoxDirector, mmnvte.Message);
            }
        }
        /// <summary>
        /// A rendezők feltölteni kivánt képét keresi ki
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonIMGDirector_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.InitialDirectory = "C:\\ProgramData\\MySQL\\MySQL Server 5.7\\Uploads";
            open.Filter = "Image Files (*.jpg)|*.jpg|All Files(*.*)|*.*";
            open.FilterIndex = 1;
            if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (open.CheckFileExists)
                {
                    string pathname = System.IO.Path.GetFullPath(open.FileName);
                    pathname = pathname.Replace("\\", "/");
                    labelKepHelyeDirector.Text = pathname;
                }
            }
        }



        /// <summary>
        /// Szinész hozzáadása az adatbázishoz
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>**************************************************************************************************************************************************
        /// 

        private void buttonFeltoltActor_Click(object sender, EventArgs e)
        {


            errorProviderActorName.Clear();
            try
            {
                MySqlConnection connection = new MySqlConnection(ConnectionString);
                connection.Open();
                MySqlCommand command = connection.CreateCommand();

                Actor newActor = new Actor(
                    textBoxActor.Text,
                    comboBoxGenderActor.Text,
                    dateTimePickerActor.Text,
                    richTextBoxActor.Text,
                    labelKépHelyeActor.Text
                    );
                ra.addActorToList(newActor);
                ra.insertActorToDatabase(newActor);
                MessageBox.Show("Sikeres feltöltés az adatbázisba");
            }
            catch (ModellMovieNotValidTitleUpperCaseException mmnvte)
            {
                errorProviderActorName.SetError(textBoxActor, mmnvte.Message);
            }



        }
        /// <summary>
        /// A szinészek képének feltöltése
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void buttonIMGActor_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.InitialDirectory = "C:\\ProgramData\\MySQL\\MySQL Server 5.7\\Uploads";
            open.Filter = "Image Files (*.jpg)|*.jpg|All Files(*.*)|*.*";
            open.FilterIndex = 1;
            if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (open.CheckFileExists)
                {
                    string pathname = System.IO.Path.GetFullPath(open.FileName);
                    pathname = pathname.Replace("\\", "/");
                    labelKépHelyeActor.Text = pathname;
                }
            }
        }
        /// <summary>
        /// Szinész hozzáadása egy filmhez
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>***************************************************************************************************************************************************************
        private void buttonActorToMovie_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(ConnectionString);
            connection.Open();
            MySqlCommand command = connection.CreateCommand();

            string actor = comboBoxActor.Text;
            string movie = comboBoxMovie.Text;

            command.CommandText = "SELECT actorId FROM actor WHERE actor_name= '" + actor + "';";
            MySqlDataReader myReader = command.ExecuteReader();
            myReader.Read();
            int act_id = myReader.GetInt32("actorId");
            myReader.Close();

            command.CommandText = "SELECT movieId FROM movie WHERE title= '" + movie + "';";
            myReader = command.ExecuteReader();
            myReader.Read();
            int mov_id = myReader.GetInt32("movieId");
            myReader.Close();

            command.CommandText = "INSERT INTO `movie_actor`(`movie_id`, `actor_id`) VALUES ( " + mov_id + " , " + act_id + " );";
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Sikeresen beillesztve az adatbázisba!");
            }
            catch (Exception ef)
            {
                MessageBox.Show("Sikertelen beillesztés!");
            }
        }

        private void label23_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Feltölti a vetitéseket
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonFeltoltVetites_Click(object sender, EventArgs e)
        {
            errorProviderPrice.Clear();
            try
            {

                MySqlConnection connection = new MySqlConnection(ConnectionString);
                connection.Open();
                MySqlCommand command = connection.CreateCommand();


                string movie = comboBoxMovieProject.Text;




                command.CommandText = "SELECT movieId FROM movie WHERE title= '" + movie + "';";
                MySqlDataReader myReader = command.ExecuteReader();
                myReader.Close();
                myReader = command.ExecuteReader();
                myReader.Read();
                int mov_id = myReader.GetInt32("movieId");
                myReader.Close();



                Projection newProjection = new Projection(
                    mov_id,
                    dateTimePickerProjection.Text,
                    comboBoxTime.Text,
                    textBoxPrice.Text
                    );
                rp.addProjectioneToList(newProjection);
                rp.addProjectionToDatabase(newProjection);
                MessageBox.Show("Sikeres feltöltés az adatbázisba");
            }
            catch (ModellProjectionNotValidPriceException mp)
            {
                errorProviderPrice.SetError(textBoxPrice, mp.Message);
            }
        }
    }
}
