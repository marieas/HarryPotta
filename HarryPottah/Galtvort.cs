﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPottah
{
    internal class Galtvort
    {
        public List<Character> Characters { get; set; }
        public MagicShop MagicShop { get; set; }


        public Galtvort(MagicShop shop)
        {
            MagicShop = shop;

            Characters = new List<Character>() { new Character("Harry Potter", "Gryffindor"),
               new Character("Hermoine Granger", "Gryffindor"),new Character("Ron Weasly", "Gryffindor")};

            Characters[0].Introduction();
            Characters[0].Introduction(" and i am happy");

            Characters[0].LeaveHogwarts(MagicShop);
        }
    }
}
