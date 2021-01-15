using System;
using System.Collections.Generic;
using System.Text;

namespace mini_RPG
{
    class Elf : BaseHeroes
    {
        public Elf(string name, int hp, int baseDamage) : base(name, hp, baseDamage)
        {
            
        }
        public  Elf () :base("Ельф", 280,120)
        {

        }
    }
}
