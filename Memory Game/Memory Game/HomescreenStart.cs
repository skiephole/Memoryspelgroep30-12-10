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
        string p1, p2;
        public HomescreenStart()
        {
            InitializeComponent();
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
            start.Playernames(p1, p2);
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
            p1 = textBox.Text;
        }

        private void HomescreenStart_Load(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            p2 = textBox.Text;
        }
    }
}
