using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Resources;

namespace Memory_Game
{
    class JesusSaves
    {
        string saveFile;
        string cards, scores, names, turn;

        public static JesusSaves Instance()
        {
            return new JesusSaves();
        }

        public void Save(TableLayoutControlCollection table, int score1, int score2, string name1, string name2, bool beurt)
        {
            int i = 16;
            foreach (Control control in table)
            {
                cards += Convert.ToString(control.Tag) + ","; //tags in de volgorde 16-1
            }

            scores = score1.ToString() + "," + score2.ToString();

            names = name1 + "," + name2;

            if (beurt)
                turn = "1";
            else
                turn = "2";

            saveFile = string.Format("{0}|{1}|{2}|{3}", cards, scores, names, turn);
        }

        public void Load()
        {
            
        }
    }
}
