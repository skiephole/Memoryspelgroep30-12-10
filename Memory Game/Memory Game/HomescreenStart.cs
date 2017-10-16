using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Memory_Game
{
    public partial class HomescreenStart : Form
    {
        Form1 start;
        public HomescreenStart()
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

            Start.Enabled = false;
        }



        

        private void Close_Click(object sender, EventArgs e)
        {
            Homescreen start = new Homescreen();
            this.Hide();
            start.ShowDialog();
            this.Close();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            start = new Form1();
            this.Hide();
            start.ShowDialog();
            this.Close();
        }

        private void Player1_TextChanged(object sender, EventArgs e)
        {
            //TextWriter txt = new StreamWriter("D:\\NHL HBO ICT\\Project Memory\\Memory spel 2\\Memory Game\\Memory Game\\tekst\\Demo.txt");
            // txt.Write(Player1.Text);
            // txt.Close();
            TextBox textBox = sender as TextBox;
            Data.playername1 = textBox.Text;

            if(string.IsNullOrWhiteSpace(Player1.Text) || string.IsNullOrWhiteSpace(textBox1.Text))
            {
                Start.Enabled = false;
            }
            else
            {
                Start.Enabled = true;
            }
        }

        private void HomescreenStart_Load(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Player1.Text) || string.IsNullOrWhiteSpace(textBox1.Text))
            {
                Start.Enabled = false;
            }
            else
            {
                Start.Enabled = true;
            }

            TextBox textBox = sender as TextBox;
            Data.playername2 = textBox.Text;
        }
    }
}
