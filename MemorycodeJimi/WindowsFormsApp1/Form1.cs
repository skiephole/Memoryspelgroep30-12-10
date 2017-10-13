using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Resources;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Image[] images = new Image[8];
        Random rnd = new Random();
        PictureBox firstClick, secondClick;

        public Form1()
        {
            InitializeComponent();
            List<MemoryCard> list = MakeList();
            MemoryCard[] catalog = MakeCatalog();

            images[0] = Properties.Resources.Nummer_1;
            images[1] = Properties.Resources.Nummer_2;
            images[2] = Properties.Resources.Nummer_3;
            images[3] = Properties.Resources.Nummer_4;
            images[4] = Properties.Resources.Nummer_5;
            images[5] = Properties.Resources.Nummer_6;
            images[6] = Properties.Resources.Nummer_7;
            images[7] = Properties.Resources.Nummer_8;
            

            foreach (Control control in tableLayoutPanel1.Controls)
            {
                AssignRandomTag(control, list);
            }

        }

        private void ImageClick(object sender, EventArgs e)
        {
            PictureBox picturebox = sender as PictureBox;
            if (firstClick == null && picturebox.BackColor != Color.Green)
            {
                firstClick = picturebox;
                picturebox.Image = images[Convert.ToInt32(picturebox.Tag)]; 
                Console.WriteLine(picturebox.Tag);
            }
            else if (firstClick != picturebox && picturebox.BackColor != Color.Green)
            {
                secondClick = picturebox;
                picturebox.Image = images[Convert.ToInt32(picturebox.Tag)];
                this.Update();
                Thread.Sleep(1000);
                Console.WriteLine(picturebox.Tag);
                ResolveMatch(firstClick, secondClick);
                firstClick = null;
                secondClick = null;
            }
        }

        private List<MemoryCard> MakeList()     //maakt een lijst met memorycardobjecten.
        {
            List<MemoryCard> paartjesLijst = new List<MemoryCard>();
            for (int i = 0; i < 8; i++)
            {
                paartjesLijst.Add(new MemoryCard(i));
                paartjesLijst.Add(new MemoryCard(i));
            }
            return paartjesLijst;
        }

        private MemoryCard[] MakeCatalog()      //maakt een catalogus voor de picturebox om zijn info in op te zoeken.
        {
            MemoryCard[] catalog = new MemoryCard[8];
            for (int i = 0, l = catalog.Length; i < l; i++)
            {
                catalog[i] = new MemoryCard(i);
            }
            return catalog;
        }

        private void AssignRandomTag(Control control, List<MemoryCard> list)
        {
            int i = rnd.Next(0, list.Count);
            control.Tag = list[i].Pair;
            list.RemoveAt(i);
        }

        private void ResolveMatch(PictureBox first, PictureBox second)
        {
            //ergens moeten we even een tijdje wachten voor player experience ofzo.
            if(Convert.ToInt32(first.Tag) == Convert.ToInt32(second.Tag))
            {
                first.BackColor = Color.Green;
                second.BackColor = Color.Green;
            }
            else
            {
                first.BackColor = Color.White;
                second.BackColor = Color.White;
            }

        }

    }
}
