using System;
using System.Collections.Generic;
using System.Text;

namespace mini_RPG
{
    class Bandit:BaseHeroes
    {
        public Bandit()
        {
            Name = "Бандит";
            HP = 320;
            BaseDamage = 90;
        }
        public void RemainingHp()
        {
            Console.WriteLine($"Оставшееся HP: {HP}");
        }
    }
}
