using System;
using System.Collections.Generic;
using System.Text;

namespace mini_RPG
{
    class BaseTeam
    {
        public BaseTeam(int numderHeroes, string nameTeam)
        {
            NumberHeroes = numderHeroes;
            NameTeam = nameTeam;

        }
        public string NameTeam { get; set; }
        private int _numberHeroes;
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
        public List<BaseHeroes> ListHeroes = new List<BaseHeroes>();
        public void PrintName()
        {
            Console.Write($"Название команды: {NameTeam}");
        }       
    }
}