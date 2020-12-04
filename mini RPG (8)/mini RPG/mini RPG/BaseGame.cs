using System;
using System.Collections.Generic;
using System.Text;

namespace mini_RPG
{
    class BaseGame
    {
        public int whomAttackPlayer;
        public int whoAttackPlayes;
        public int whomAttackBot;
        public int whoAttackBot;
        public bool inGame;
        BaseTeam baseTeam = new BaseTeam();
        public void TeamName()
        {
            Console.Write("Введите название команды: ");
            baseTeam.NameTeam = Console.ReadLine();
        }
        public void NumberOfHeroes()
        {
            Console.Write("Сколько будет героев в твоей команде(1-8): ");
            string input = Console.ReadLine();
            int.TryParse(input, out baseTeam.NumberHeroes);
        }
        public void CommandHeroes()
        {
            string input = null;
            int num = 0;
            int numHeroes;
            while (num != baseTeam.NumberHeroes)
            {
                input = Console.ReadLine();
                int.TryParse(input, out numHeroes);

                if (numHeroes < 9)
                {
                    if (!baseTeam.ListHeroes.Contains(baseTeam.Heroes[numHeroes - 1]))
                    {

                        
                    }
                    else
                    {
                        Console.WriteLine("Нельзя выбирать одного и того же перса несколько раз");
                    }
                }
                else
                {
                    Console.WriteLine("Укажите номера персов которых вы хотите добавить себе в команду (НЕ БОЛЬШЕ 8): ");

                }
            }
        }
        public void StartGame()
        {
            Bandit bandit = new Bandit();
            Berserker berserker = new Berserker();
            Druid druid = new Druid();
            Elf elf = new Elf();
            Mage mage = new Mage();
            Pyrotechnic pyrotechnic = new Pyrotechnic();
            Samurai samurai = new Samurai();
            Warrior warrior = new Warrior();
            TeamName();
            NumberOfHeroes();      
            while (baseTeam.NumberHeroes > 8||baseTeam.NumberHeroes < 0)
            {
                NumberOfHeroes();
            }
            for (int i = 0; i < baseTeam.NumberHeroes; i++)
            {
                Console.WriteLine("Введите номер персонажа которого хотите добавить в команду: ");
                bandit.PrintInfo();
                berserker.PrintInfo();
                druid.PrintInfo();
                elf.PrintInfo();
                mage.PrintInfo();
                pyrotechnic.PrintInfo();
                samurai.PrintInfo();
                warrior.PrintInfo();
            } 
        }
        public void Game()
        {

        }
        public void EndGame()
        {

        }
    }
}
