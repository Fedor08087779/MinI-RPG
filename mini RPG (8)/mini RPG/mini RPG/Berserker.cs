using System;
using System.Collections.Generic;
using System.Text;

namespace mini_RPG
{
    class Berserker : BaseHeroes
    {
        public Berserker(string name, int hp, int baseDamage) : base(name, hp, baseDamage)
        {

        }
        public Berserker() : base( "Берсерк", 550, 50 )
        {

        }     
    }
}
