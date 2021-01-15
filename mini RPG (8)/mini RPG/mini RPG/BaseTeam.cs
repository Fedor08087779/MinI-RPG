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
        Bandit bandit = new Bandit("Бандит", 320, 90);
        Berserker berserker = new Berserker("Берсерк", 550, 50);
        Druid druid = new Druid("Друид", 350, 110);
        Elf elf = new Elf("Ельф", 280, 120);
        Mage mage = new Mage("Маг", 250, 130);
        Pyrotechnic pyrotechnic = new Pyrotechnic("Пиротехник", 130, 200);
        Samurai samurai = new Samurai("Самурай", 500, 70);
        Warrior warrior = new Warrior("Воин", 450, 85);
        public List<BaseHeroes> ListHeroes {get; private set;}
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
        public void PrintName()
        {
            Console.Write($"Название команды: {NameTeam}");
        }   
        public void AddHeroe()
        {
            switch(numHeroe)
            {
                case 0:
                    ListHeroes.Add(bandit);
                    break;
                case 1:
                    ListHeroes.Add(berserker);
                    break;
                case 2:
                    ListHeroes.Add(druid);
                    break;
                case 3:
                    ListHeroes.Add(elf);
                    break;
                case 4:
                    ListHeroes.Add(mage);
                    break;
                case 5:
                    ListHeroes.Add(pyrotechnic);
                    break;
                case 6:
                    ListHeroes.Add(samurai);
                    break;
                case 7:
                    ListHeroes.Add(warrior);
                    break;
            }






        }
    }
}