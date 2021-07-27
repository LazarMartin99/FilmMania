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
    public partial class ActorSearch : Form
    {
        public ActorSearch()
        {
            InitializeComponent();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            ActorSearchResult actor_result = new ActorSearchResult(textBox1.Text);
            actor_result.Show();
            this.Hide();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            UserInterface ui = new UserInterface();
            ui.Show();
            this.Hide();
        }
    }
}
