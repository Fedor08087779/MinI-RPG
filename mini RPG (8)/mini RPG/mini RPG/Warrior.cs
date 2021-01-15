using System;
using System.Collections.Generic;
using System.Text;

namespace mini_RPG
{
    class Warrior:BaseHeroes
    {
        public Warrior(string name, int hp, int baseDamage) : base(name, hp, baseDamage)
        {
            
        }
        public Warrior():base("Воин", 450,85)
        {

        }
    }
}
