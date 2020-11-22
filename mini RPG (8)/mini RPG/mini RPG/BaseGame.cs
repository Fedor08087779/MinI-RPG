using System;
using System.Collections.Generic;
using System.Text;

namespace mini_RPG
{
    class BaseGame:BaseTeam
    {
        public int whomAttackPlayer;
        public int whoAttackPlayes;
        public int whomAttackBot;
        public int whoAttackBot;
        public bool inGame;
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
            Console.Write("Введите название команды: ");
            NameTeam = Console.ReadLine();
            Console.Write("Сколько будет героев в твоей команде(1-8): ");
            string input = Console.ReadLine();
            int.TryParse(input, out NumberHeroes);
            while (NumberHeroes > 8)
            {
                Console.WriteLine("Сколько персов будет в вашей команде (1-8!!!): ");
                input = Console.ReadLine();
                int.TryParse(input, out NumberHeroes);
            }
            for (int i = 0; i < NumberHeroes; i++)
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
