using System;
using System.Collections.Generic;
using System.Text;

namespace mini_RPG
{
    class BaseTeam
    {
        public BaseTeam(int numderHeroes, string nameTeam)
        {
            _numberHeroes = numderHeroes;
            NameTeam = nameTeam;
        }
        public string NameTeam { get; set; }
        private int _numberHeroes;
        private int _numHeroe;
        public BaseHeroes BaseHeroes { get; set; }
        Bandit bandit = new Bandit("Бандит", 320, 90);
        Berserker berserker = new Berserker("Берсерк", 550, 50);
        Druid druid = new Druid("Друид", 350, 110);
        Elf elf = new Elf("Ельф", 280, 120);
        Mage mage = new Mage("Маг", 250, 130);
        Pyrotechnic pyrotechnic = new Pyrotechnic("Пиротехник", 130, 200);
        Samurai samurai = new Samurai("Самурай", 500, 70);
        Warrior warrior = new Warrior("Воин", 450, 85);
        protected List<BaseHeroes> ListHeroes {get; private set;}
        public int NumberHeroes
        {
            get
            {
                return _numberHeroes;
            }
            set
            {
                if (value <= 0)
                {
                    _numberHeroes = 0;
                }
                else if (value >= 9)
                {
                    _numberHeroes = 8;
                }
                else 
                {
                    _numberHeroes = value;
                }
            }
        }
        private int numHeroe
        {
            get
            {
                return _numHeroe;
            }
            set
            {
                if (value <= 0)
                {
                    _numHeroe = 0;
                }
                else if (value >= 8)
                {
                    _numHeroe = 7;
                }
                else
                {
                    _numHeroe = value;
                }
            }
        }
        public void PrintTeamName(string NameTeam)
        {
            Console.Write($"Название команды: {NameTeam}");
        }   
        public void AddBandit(Bandit bandit)
        {
            ListHeroes.Add(bandit);
        }
        public void AddBerserker(Berserker berserker)
        {
            ListHeroes.Add(berserker);
        }
        public void AddDruid(Druid druid)
        {
            ListHeroes.Add(druid);
        }
        public void AddElf(Elf elf)
        {
            ListHeroes.Add(elf);
        }
        public void AddMage(Mage mage)
        {
            ListHeroes.Add(mage);
        }
        public void AddPyrotechnic(Pyrotechnic pyrotechnic)
        {
            ListHeroes.Add(pyrotechnic);
        }
        public void AddSamurai(Samurai samurai)
        {
            ListHeroes.Add(samurai);
        }
        public void AddWarrior(Warrior warrior)
        {
            ListHeroes.Add(warrior);
        }
    }
}