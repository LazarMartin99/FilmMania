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
    public partial class DirectorSearch : Form
    {
        public DirectorSearch()
        {
            InitializeComponent();
        }

        private void buttonSearch_Click_1(object sender, EventArgs e)
        {

            DirectorSearchResult dsr = new DirectorSearchResult(textBox1.Text);
            dsr.Show();
            this.Hide();
        }

        private void buttonBack_Click_1(object sender, EventArgs e)
        {
            UserInterface ui = new UserInterface();
            ui.Show();
            this.Hide();
        }
    }
}
