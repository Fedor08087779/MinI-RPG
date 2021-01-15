using System;
using System.Collections.Generic;
using System.Text;

namespace mini_RPG
{
    class Samurai : BaseHeroes
    {
        public Samurai(string name, int hp, int baseDamage) : base(name, hp, baseDamage)
        {
            
        }
        public Samurai():base("Самурай", 500,70)
        {

        }
    }
}
