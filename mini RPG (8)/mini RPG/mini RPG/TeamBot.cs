using System;
using System.Collections.Generic;
using System.Text;

namespace mini_RPG
{
    class TeamBot:BaseTeam
    {
        List<string> Names = new List<string>() { "Deadly Squad", "Демонический шоколадки", "Святые Дьяволы", "Таёжный клан", "АпеЛЬсиНКи" };
        public void RandomName()
        {
            Random generator = new Random();
            int randomNum = generator.Next(0,5);
            NameTeam = Names[randomNum];
        }
    }
}
