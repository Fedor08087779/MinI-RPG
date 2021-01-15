using System;
using System.Collections.Generic;
using System.Text;

namespace mini_RPG
{
    class Druid : BaseHeroes
    {
        public Druid(string name, int hp, int baseDamage) : base(name, hp, baseDamage)
        {
           
        }
        public Druid() : base("Друид", 350,110)
        {

        }

    }
}
