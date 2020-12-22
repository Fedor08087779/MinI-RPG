using System;
using System.Collections.Generic;
using System.Text;

namespace mini_RPG
{
    class BaseHeroes
    {
        Random generator = new Random();
        public string Name { get;  set; }
        public int HP { get;  set; }
        public int BaseDamage { get;  set; }
        public int RandomDamage { get;  set; }
        public BaseHeroes(string name, int hp, int baseDamage)
        {
            Name = name;
            HP = hp;
            BaseDamage = baseDamage;
        }
        public void PrintInfo()
        {
            if (HP > 0)
            {
                Console.WriteLine($"{Name} - {HP} HP, урон: {BaseDamage}");
            }
            else
            {
                Console.WriteLine($"{Name} - {HP} HP, урон: {BaseDamage} - [Убит]");
            }
        }
        public int CountDamage()
        {
            int calculateDamage = generator.Next(BaseDamage / 4 * 3, BaseDamage / 4 * 5);
            return calculateDamage;
        }
        public void TakeDamage(int damageReceived)
        {
            if (HP - damageReceived <= 0)
            {
                HP = 0;
            }
            else
            {
                HP -= damageReceived;
            }
        }
    }
}