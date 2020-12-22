using System;
using System.Collections.Generic;
using System.Text;

namespace mini_RPG
{
    class Elf : BaseHeroes
    {
        public Elf(string name, int hp, int baseDamage) : base(name, hp, baseDamage)
        {
            Name = "Ельф";
            HP = 280;
            BaseDamage = 120;
        }
        
    }
}
