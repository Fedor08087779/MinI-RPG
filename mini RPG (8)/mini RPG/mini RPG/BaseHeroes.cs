using System;
using System.Collections.Generic;
using System.Text;

namespace mini_RPG
{
    class BaseHeroes
    {
        Random generator = new Random();
        public string Name;
        public int HP;
        public int BaseDamage;
        public int RandomDamage;
        public int Number;
        public void PrintInfo()
        {
            if (HP > 0)
            {
                Console.WriteLine($"{Number}.{Name} - {HP} HP, урон: {BaseDamage}");
            }
            else
            {
                Console.WriteLine($"{Number}.{Name} - {HP} HP, урон: {BaseDamage} - [Убит]");
            }
        }
        public int CalculateDamage()
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