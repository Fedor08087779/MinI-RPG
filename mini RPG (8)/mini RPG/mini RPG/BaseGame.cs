using System;
using System.Collections.Generic;
using System.Text;

namespace mini_RPG
{
    class BaseGame
    {
        public int whomAttackPlayer { get; private set; }
        public int whoAttackPlayes { get; private set; }
        public int whomAttackBot { get; private set; }
        public int whoAttackBot { get; private set; }
        public bool inGame { get; private set; }
        InputOutput inputOutput = InputOutput.getInstance();
        Bandit bandit = new Bandit("Бандит", 320, 90);
        Berserker berserker = new Berserker("Берсерк", 550, 50);
        Druid druid = new Druid("Друид", 350, 110);
        Elf elf = new Elf("Ельф", 280, 120);
        Mage mage = new Mage("Маг", 250, 130);
        Pyrotechnic pyrotechnic = new Pyrotechnic("Пиротехник", 130, 200);
        Samurai samurai = new Samurai("Самурай", 500, 70);
        Warrior warrior = new Warrior("Воин", 450, 85);
        BaseTeam baseTeam = new BaseTeam(0, null);   
        public void TeamName()
        {
            inputOutput.Output("Введите название команды: ");
            baseTeam.NameTeam = inputOutput.Input();
        }
        public void NumberOfHeroes()
        {
            inputOutput.Output("Сколько будет героев в твоей команде(1-8): ");
            int.TryParse(inputOutput.Input(), out int num);
            BaseTeam.NumberHeroes = num;
        }
        public void CommandHeroes()
        {
            List<BaseHeroes> Heroes = new List<BaseHeroes>() { bandit, berserker, druid, elf, mage, pyrotechnic, samurai, warrior };
            string input = null;
            int num = 0;
            int numHeroes;
            while (num != baseTeam.NumberHeroes)
            {
                input = inputOutput.Input();
                int.TryParse(input, out numHeroes);
                if (numHeroes < 9)
                {
                    if(!baseTeam.ListHeroes.Contains(Heroes[numHeroes - 1]))
                    {
                        baseTeam.ListHeroes.Add(Heroes[numHeroes - 1]);
                        num++;
                    }
                    else
                    {
                        inputOutput.Output("Нельзя выбирать одного и того же перса несколько раз");
                    }
                }
                else
                {
                    inputOutput.Output("Укажите номера персов которых вы хотите добавить себе в команду (НЕ БОЛЬШЕ 8): ");

                }
            }
        }
        public void StartGame()
        {            
            TeamName();
            NumberOfHeroes();          
            for (int i = 0; i < baseTeam.NumberHeroes; i++)
            {
                inputOutput.Output("Введите номер персонажа которого хотите добавить в команду: ");
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