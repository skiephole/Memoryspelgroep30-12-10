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
using System.IO;

namespace Memory_Game

{
    public partial class Form1 : Form
    {
        int bonusCard; //moet nog in de savefile
        int streak = 0;  //moet nog in de savefile
        string player1, player2;
        int score1, score2;
        Random rnd = new Random();
        PictureBox firstClick, secondClick;
        double timeleft = 10.49;
        Image[] imagesmario = new Image[8];
        Image[] imagesmeme = new Image[8];
        Image[] imagespokemon = new Image[8];


        public Form1()
        {

            InitializeComponent();

            List<MemoryCard> list = MakeList();
            label1.BackColor = Color.Red;
            MemoryCard[] catalog = MakeCatalog();


            imagesmario[0] = Properties.Resources.MAR1_2;
            imagesmario[1] = Properties.Resources.MAR3_4;
            imagesmario[2] = Properties.Resources.MAR5_6;
            imagesmario[3] = Properties.Resources.MAR7_8;
            imagesmario[4] = Properties.Resources.MAR9_10;
            imagesmario[5] = Properties.Resources.MAR11_12;
            imagesmario[6] = Properties.Resources.MAR13_14;
            imagesmario[7] = Properties.Resources.MAR15_16;

            imagesmeme[0] = Properties.Resources.MEME1_2;
            imagesmeme[1] = Properties.Resources.MEME3_4;
            imagesmeme[2] = Properties.Resources.MEME5_6;
            imagesmeme[3] = Properties.Resources.MEME7_8;
            imagesmeme[4] = Properties.Resources.MEME9_10;
            imagesmeme[5] = Properties.Resources.MEME11_12;
            imagesmeme[6] = Properties.Resources.MEME13_14;
            imagesmeme[7] = Properties.Resources.MEME15_16;

            imagespokemon[0] = Properties.Resources.POKE1_2;
            imagespokemon[1] = Properties.Resources.POKE3_4;
            imagespokemon[2] = Properties.Resources.POKE5_6;
            imagespokemon[3] = Properties.Resources.POKE7_8;
            imagespokemon[4] = Properties.Resources.POKE9_10;
            imagespokemon[5] = Properties.Resources.POKE11_12;
            imagespokemon[6] = Properties.Resources.POKE13_14;
            imagespokemon[7] = Properties.Resources.POKE15_16;

            foreach (Control control in tableLayoutPanel1.Controls)
            {
                AssignRandomTag(control, list);
                Console.WriteLine(control.Name);
            }
            bonusCard = rnd.Next(0, 8);
            Console.WriteLine("Joker = " + bonusCard);
            

        }

        private void ImageClick(object sender, EventArgs e)
        {
            PictureBox picturebox = sender as PictureBox;
            if (firstClick == null && picturebox.BackColor != Color.Green)
            {
                firstClick = picturebox;
                picturebox.Image = imagesmario[Convert.ToInt32(picturebox.Tag)];
                Console.WriteLine(picturebox.Tag);
            }
            else if (firstClick != picturebox && picturebox.BackColor != Color.Green)
            {
                secondClick = picturebox;
                picturebox.Image = imagesmario[Convert.ToInt32(picturebox.Tag)];
                this.Update();
                Thread.Sleep(0);
                Console.WriteLine(picturebox.Tag);
                ResolveMatch(firstClick, secondClick);
                ResetTimer();                
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

        private void label1_Click(object sender, EventArgs e)
        {
           
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeleft > 0)
            {
                timeleft = timeleft - 0.5;

                string time = timeleft.ToString("00");
                label5.Text = time;
            }
            else
            {
                timer1.Stop();
                label6.Text = "No time \nleft";
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        public void Playernames(string name1, string name2)
        {
            player1 = name1;
            label1.Text = player1;
            player2 = name2;
            label2.Text = player2;

        }

        private void ResolveMatch(PictureBox first, PictureBox second)
        {
            //ergens moeten we even een tijdje wachten voor player experience ofzo.
            if(Convert.ToInt32(first.Tag) == Convert.ToInt32(second.Tag))
            {
                first.BackColor = Color.Green;
                second.BackColor = Color.Green;
                HandleScore(Convert.ToInt32(first.Tag));
            }
            else
            {
                first.BackColor = Color.White;
                second.BackColor = Color.White;
                Nextturn();
            }

        }

        private void ResetTimer()
        {
            timeleft= 10.49;
            timer1.Start();
            label6.Text = "";
        }

        private void Nextturn()
        {
            if (label1.BackColor == Color.Red)
            {
                label1.BackColor = Color.MediumSlateBlue;
                label2.BackColor = Color.Red;
            }
            else if (label2.BackColor == Color.Red)
            {
                label2.BackColor = Color.MediumSlateBlue;
                label1.BackColor = Color.Red;
            }

            streak = 0;
        }

        private void HandleScore(int joker)
        {
            int scorePlus = 50;

            if (joker == bonusCard)
            {
                scorePlus += 50;
            }
            scorePlus += 25 * streak;

            if(label1.BackColor == Color.Red)
            {
                score1 += scorePlus;
                label7.Text = score1.ToString();
            }
            else
            {
                score2 += scorePlus;
                label8.Text = score2.ToString();
            }


            streak++;
        }

    }
}
