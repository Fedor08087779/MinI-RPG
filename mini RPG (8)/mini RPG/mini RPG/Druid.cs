using System;
using System.Collections.Generic;
using System.Text;

namespace mini_RPG
{
    class Druid : BaseHeroes
    {
        public Druid()
        {
            Name = "Друид";
            HP = 350;
            BaseDamage = 110;
        }
        public void RemainingHp()
        {
            Console.WriteLine($"Оставшееся HP: {HP}");
        }
    }
}
