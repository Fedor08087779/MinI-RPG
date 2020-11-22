using System;
using System.Collections.Generic;
using System.Text;

namespace mini_RPG
{
    class BaseTeam:BaseHeroes
    {
        public string NameTeam;
        public int NumberHeroes;
        public void PrintName()
        {
            Console.Write($"Название команды: {NameTeam}");
        }        
    }
}
