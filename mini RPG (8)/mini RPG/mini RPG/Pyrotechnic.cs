using System;
using System.Collections.Generic;
using System.Text;

namespace mini_RPG
{
    class Pyrotechnic : BaseHeroes
    {
        public Pyrotechnic(string name, int hp, int baseDamage) : base(name, hp, baseDamage)
        {
            
        }
        public Pyrotechnic():base("Пиротехник", 130,200)
        {

        }
    }
}
