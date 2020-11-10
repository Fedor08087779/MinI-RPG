using System;
using System.Collections.Generic;
using System.Text;

namespace mini_RPG
{
    class Warrior:BaseHeroes
    {
        public Warrior()
        {
            Name = "Воин";
            HP = 450;
            BaseDamage = 85;
        }
        public void RemainingHp()
        {
            Console.WriteLine($"Оставшееся HP: {HP}");
        }
    }
}
