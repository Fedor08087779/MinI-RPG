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
        public int ManyHeroes()
        {
            Console.Write("Сколько будет героев в твоей команде(1-8): ");
            string input = Console.ReadLine();
            int.TryParse(input, out int NumberHeroes);
            while (NumberHeroes > 8)
            {
                Console.WriteLine("Сколько персов будет в вашей команде (1-8!!!): ");
                input = Console.ReadLine();
                int.TryParse(input, out NumberHeroes);
            }
            return NumberHeroes;
        }
    }
}
