using System;
using System.Collections.Generic;
using System.Text;

namespace mini_RPG
{
    class BaseHeroes
    {
        public Random generator = RandomGenerator.GetRandom();
        public Random Random { get; set; }
        InputOutput inputOutput = InputOutput.getInstance();
        public void RandomNumber()
        {
            Random = RandomGenerator.GetRandom();
        }
        public string Name { get;  set; }
        public int HP { get;  set; }
        public int BaseDamage { get; private set; }

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
                inputOutput.Output($"{Name} - {HP} HP, урон: {BaseDamage}");
            }
            else
            {
                inputOutput.Output($"{Name} - {HP} HP, урон: {BaseDamage} - [Убит]");
            }
        }
        public void CountDamage()
        {
            RandomNumber();
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