using System;
using System.Collections.Generic;
using System.Text;

namespace mini_RPG
{
    class Pyrotechnic : BaseHeroes
    {
        public Pyrotechnic()
        {
            Name = "Пиротехник";
            HP = 130;
            BaseDamage = 200;
        }
        public void RemainingHp()
        {
            Console.WriteLine($"Оставшееся HP: {HP}");
        }
    }
}
