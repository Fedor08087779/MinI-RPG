using System;
using System.Collections.Generic;
using System.Text;

namespace mini_RPG
{
    class BaseTeam
    {
        public string NameTeam;
        public void PrintName()
        {
            Console.Write($"Название команды: {NameTeam}");
        }
    }
}
