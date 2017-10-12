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
    public partial class HomescreenStart : Form
    {
        Form1 start;
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
            this.Hide();
            start.ShowDialog();
            this.Close();
        }

        private void Player1_TextChanged(object sender, EventArgs e)
        {
            TextBox textbox = sender as TextBox;
            start.Playernames(1, textbox.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
