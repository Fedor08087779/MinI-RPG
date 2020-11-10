using System;
using System.Collections.Generic;
using System.Text;

namespace mini_RPG
{
    class Berserker : BaseHeroes
    {
        public Berserker()
        {
            Name = "Берсерк";
            HP = 550;
            BaseDamage = 50;
        }
        public void RemainingHp()
        {
            Console.WriteLine($"Оставшееся HP: {HP}");
        }
    }
}
