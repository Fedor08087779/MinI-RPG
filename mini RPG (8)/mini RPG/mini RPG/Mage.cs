using System;
using System.Collections.Generic;
using System.Text;
namespace mini_RPG
{
    class Mage:BaseHeroes
    {
        public Mage(string name, int hp, int baseDamage) : base(name, hp, baseDamage)
        {
            Name = "Маг";
            HP = 250;
            BaseDamage = 130;
        }
       
    }
}