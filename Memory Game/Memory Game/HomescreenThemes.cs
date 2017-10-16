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
    public partial class HomescreenThemes : Form
    {
        
        Homescreen start;
        public HomescreenThemes()
        {
            InitializeComponent();

            if (Data.mario == true)
            {
                this.BackgroundImage = Properties.Resources.MARbackground;

            }

            if (Data.meme == true)
            {
                this.BackgroundImage = Properties.Resources.MEMEbackground;

            }

            if (Data.poke == true)
            {
                this.BackgroundImage = Properties.Resources.POKEbackground;

            }

        }

        private void Back_Click(object sender, EventArgs e)
        {
            start = new Homescreen();            
            this.Hide();
            start.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Data.mario = true;
            Data.meme = false;
            Data.poke = false;
            this.BackgroundImage = Properties.Resources.MARbackground;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Data.mario = false;
            Data.meme = true;
            Data.poke = false;
            this.BackgroundImage = Properties.Resources.MEMEbackground;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Data.mario = false;
            Data.meme = false;
            Data.poke = true;
            this.BackgroundImage = Properties.Resources.POKEbackground;
        }
    }
}
