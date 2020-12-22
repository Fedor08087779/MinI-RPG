using System;
using System.Collections.Generic;
using System.Text;

namespace mini_RPG
{
    class Bandit:BaseHeroes
    {
        public Bandit(string name, int hp, int baseDamage) : base (name, hp, baseDamage)
        {
            Name = "Бандит";
            HP = 320;
            BaseDamage = 90;
        }
        
    }
}
