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
        public HomescreenThemes()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Homescreen start = new Homescreen();
            this.Hide();
            start.ShowDialog();
            this.Close();
        }
    }
}
