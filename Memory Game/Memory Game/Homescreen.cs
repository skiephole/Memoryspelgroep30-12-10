using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Memory_Game
{
    public partial class Homescreen : Form
    {
        public static int kleur = 3;

        public void ThemePasser(bool mario, bool meme, bool poke)
        {
            if (mario == true)
            {
                this.BackgroundImage = Properties.Resources.MARbackground;

            }

            if (meme == true)
            {
                this.BackgroundImage = Properties.Resources.MEMEbackground;

            }

            if (poke == true)
            {
                this.BackgroundImage = Properties.Resources.POKEbackground;

            }

        }

        public Homescreen()
        {
            InitializeComponent();
        }

        private void Quit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Start_Click(object sender, EventArgs e)
        {
            HomescreenStart start = new HomescreenStart();
            this.Hide();
            start.ShowDialog();
            this.Close();
        }

        private void HighScores_Click(object sender, EventArgs e)
        {
            HomescreenHighscores start = new HomescreenHighscores();
            this.Hide();
            start.ShowDialog();
            this.Close();          
        }

        private void Themes_Click(object sender, EventArgs e)
        {
            HomescreenThemes start = new HomescreenThemes();
            this.Hide();
            start.ShowDialog();
            this.Close();
        }
    }
}
