using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Memory_Game
{
    class Data
    {
        public static Data Instance()
        {
            return new Data();
        }

        public static string playername1, playername2;
        public static bool mario = false, meme = false, poke = false;
    }
}
