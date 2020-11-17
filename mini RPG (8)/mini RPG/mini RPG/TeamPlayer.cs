using System;
using System.Collections.Generic;
using System.Text;

namespace mini_RPG
{
    class TeamPlayer:BaseTeam
    {
        public void NameSelection()
        {
            Console.Write("Введите название команды: ");
            NameTeam = Console.ReadLine();
        }
    }
}
