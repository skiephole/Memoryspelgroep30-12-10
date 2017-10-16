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
        bool mario = false, meme = false, poke = false;
        Homescreen start;
        public HomescreenThemes()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            start = new Homescreen();
            start.ThemePasser(mario, meme, poke);
            this.Hide();
            start.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Data.mario = true;
            Data.meme = false;
            Data.poke = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Data.mario = false;
            Data.meme = true;
            Data.poke = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Data.mario = false;
            Data.meme = false;
            Data.poke = true;
        }
    }
}
