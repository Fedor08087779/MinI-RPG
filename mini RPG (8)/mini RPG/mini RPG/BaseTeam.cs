using System;
using System.Collections.Generic;
using System.Text;

namespace mini_RPG
{
    class BaseTeam
    {
        public string NameTeam;
        public int NumberHeroes;
        public List<BaseHeroes> ListHeroes = new List<BaseHeroes>();
        public List<string> Heroes = new List<string>() {"bandit", "berserk", "druid", "elf", "mage", "pyrotechnic", "samurai", "warrior" };
        public void PrintName()
        {
            Console.Write($"Название команды: {NameTeam}");
        }       
    }
}