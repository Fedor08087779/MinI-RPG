
using System;
using System.Collections;
using System.Collections.Generic;
namespace MINI_RPG
{
    class Program
    {
        static List<string> playerHeroes;
        static List<string> botHeroes;
        static List<int> playerHeroesHP;
        static List<int> botHeroesHP;
        static List<int> playerHeroesDamage;
        static List<int> botHeroesDamage;
        static List<string> Heroes;
        static List<int> HeroesHP;
        static List<int> HeroesDamage;
        static List<string> deathPlayer;
        static List<string> deathBot;
        static string playerTeam;
        static string botTeam;
        static int manuHeroes;
        static int botGeneralHP;
        static int playerGeneralHP;
        static Random generator = new Random();
        static void startGame()
        {
            // списки                                                                                                   
            List<string> teamsForBot = new List<string>() { "Deadly Squad", "Демонический шоколадки", "Святые Дьяволы", "Таёжный клан", "АпеЛЬсиНКи" };
            Heroes = new List<string>() { "Маг", "Воин", "Бандит", "Пиротехник", "Друид", "Эльф", "Cамурай", "Берсерк" };
            HeroesHP = new List<int>() { 250, 450, 320, 230, 450, 300, 350, 400 };
            HeroesDamage = new List<int>() { 100, 85, 110, 160, 130, 125, 110, 145 };
            deathPlayer = new List<string>();
            deathBot = new List<string>();
            playerHeroes = new List<string>();
            botHeroes = new List<string>();
            playerHeroesHP = new List<int>();
            botHeroesHP = new List<int>();
            playerHeroesDamage = new List<int>();
            botHeroesDamage = new List<int>();
            string input = "";
            int numBotTeam;
            int randomNum;
            int numHeroes;


            Console.Write("Придумай имя своей команды: ");
            playerTeam = Console.ReadLine();
            numBotTeam = generator.Next(5);
            botTeam = teamsForBot[numBotTeam];
            Console.Clear();
            Console.WriteLine($"Вы выбрали имя: {playerTeam}");
            Console.WriteLine($"Компьютер выбрал имя: {botTeam}");
            //--------------------------------------------------------------------------------------------------------------------------------------------
            // сколько персвов участвуют в игре 
            Console.WriteLine("Сколько персов будет в вашей команде (не больше 8):");
            input = Console.ReadLine();
            int.TryParse(input, out manuHeroes);
            while (manuHeroes > 8)
            {
                Console.WriteLine("Сколько персов будет в вашей команде (НЕ БОЛЬШЕ 8!!!):");
                input = Console.ReadLine();
                int.TryParse(input, out manuHeroes);
            }
            //--------------------------------------------------------------------------------------------------------------------------------------------
            // какие персы участвуют в игре            
            input = "";
            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine($"{i + 1} {Heroes[i]} ({HeroesHP[i]}HP), базовый урон: {HeroesDamage[i]} ");
            }
            Console.WriteLine("Укажите номера персов которых вы хотите добавить себе в команду (через Enter): ");
            int num = 0;
            while (num != manuHeroes)
            {
                input = Console.ReadLine();
                int.TryParse(input, out numHeroes);

                if (numHeroes < 9)
                {
                    if (!playerHeroes.Contains(Heroes[numHeroes - 1]))
                    {

                        playerHeroes.Add(Heroes[numHeroes - 1]);
                        playerHeroesHP.Add(HeroesHP[numHeroes - 1]);
                        playerHeroesDamage.Add(HeroesDamage[numHeroes - 1]);
                        deathPlayer.Add("");
                        num++;
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
            num = 0;
            while (num < manuHeroes)
            {

                randomNum = generator.Next(8);
                if (!botHeroes.Contains(Heroes[randomNum]))
                {
                    botHeroes.Add(Heroes[randomNum]);
                    botHeroesHP.Add(HeroesHP[randomNum]);
                    botHeroesDamage.Add(HeroesDamage[randomNum]);

                    deathBot.Add("");
                    num++;
                }
            }
            //--------------------------------------------------------------------------------------------------------------------------------------------
            Console.WriteLine("Для продолжения нажмите Enter... ");
            Console.ReadLine();
            Console.Clear();
            //--------------------------------------------------------------------------------------------------------------------------------------------
            // таблица игры персов и их характеристик  
            Console.WriteLine($"Команда {playerTeam}: ");
            Console.WriteLine("==========================================");
            for (int i = 0; i < manuHeroes; i++)
            {
                Console.WriteLine($"{i + 1} {playerHeroes[i]} ({playerHeroesHP[i]}HP), базовый урон: {playerHeroesDamage[i]}");
            }
            Console.WriteLine("==========================================\n \n \n ");
            Console.WriteLine($"Команда {botTeam}");
            Console.WriteLine("==========================================");
            for (int i = 0; i < manuHeroes; i++)
            {
                Console.WriteLine($"{i + 1} {botHeroes[i]} ({botHeroesHP[i]}HP), базовый урон: {botHeroesDamage[i]}");
            }
            Console.WriteLine("==========================================");
        }
        static void mainGame()
        {

            string input = "";
            int whomAttackPlayer;
            int whoAttackPlayer;
            int whoAttackBot;
            int whomAttackBot;
            int randomDamagePlayer;
            int randomDamageBot;
            bool inGame = true;
            
            while (inGame)
            {
                //--------------------------------------------------------------------------------------------------------------------------------------------
                // атака игрока
                Console.WriteLine("Выбери, кем атaковать: ");
                input = Console.ReadLine();
                int.TryParse(input, out whoAttackPlayer);
                while (whoAttackPlayer > manuHeroes || whoAttackPlayer < 0 || deathPlayer[whoAttackPlayer - 1].Contains("- [убит]"))
                {
                    Console.WriteLine($"Укажите номер героя которым вы хотите атаковать. (не больше {manuHeroes} и не меньше 0) и/или (нельзя атаковать мертвым героем)");
                    input = Console.ReadLine();
                    int.TryParse(input, out whoAttackPlayer);
                }
                whoAttackPlayer--;
                Console.WriteLine("Выбери, кого атаковать: ");
                input = Console.ReadLine();
                int.TryParse(input, out whomAttackPlayer);
                while (whomAttackPlayer > manuHeroes || whomAttackPlayer < 0 || deathBot[whomAttackPlayer - 1].Contains("- [убит]"))
                {

                    Console.WriteLine($"Укажите номер героя которого вы хотите атаковать. (не больше {manuHeroes} и не меньше 0) и/или (нельзя атаковать мертвого героя)");
                    input = Console.ReadLine();
                    int.TryParse(input, out whomAttackPlayer);
                }
                whomAttackPlayer--;
                randomDamagePlayer = generator.Next(playerHeroesDamage[whoAttackPlayer] / 5 * 4, playerHeroesDamage[whoAttackPlayer] / 5 * 6);
                //--------------------------------------------------------------------------------------------------------------------------------------------
                // атака бота
                whoAttackBot = generator.Next(manuHeroes);                
                while (deathBot[whoAttackBot].Contains("- [убит]"))
                {
                    whoAttackBot = generator.Next(manuHeroes);
                }

                whomAttackBot = generator.Next(manuHeroes);
                while (deathPlayer[whomAttackBot].Contains("- [убит]"))
                {
                    whomAttackBot = generator.Next(manuHeroes);
                }
                randomDamageBot = generator.Next(botHeroesDamage[whoAttackBot] / 5 * 4, botHeroesDamage[whoAttackBot] / 5 * 6);
                Console.Clear();
                if (botHeroesHP[whomAttackPlayer] - randomDamagePlayer>0)
                {
                    botHeroesHP[whomAttackPlayer] -= randomDamagePlayer;
                }
                else
                {
                    botHeroesHP[whomAttackPlayer] = 0;
                    deathBot[whomAttackPlayer] = "- [убит]";
                }

                if (playerHeroesHP[whomAttackBot] - randomDamageBot  > 0)
                {
                    playerHeroesHP[whomAttackBot] -= randomDamageBot;
                }
                else
                {
                    playerHeroesHP[whomAttackBot] = 0;
                    deathPlayer[whomAttackBot] = "- [убит]";
                }                
                //---------------------------------------------------------------------------------------------------------------------------------------------
                // Результат хода игрока                        
                Console.WriteLine($"{playerHeroes[whoAttackPlayer]} ({playerTeam}) нанёс {randomDamagePlayer} единиц урона {botHeroes[whomAttackPlayer]} ({botTeam}) {deathBot[whomAttackPlayer]}");
                //--------------------------------------------------------------------------------------------------------------------------------------------
                // Результат хода бота          
                Console.WriteLine($"{botHeroes[whoAttackBot]} ({botTeam}) нанёс {randomDamageBot} единиц урона {playerHeroes[whomAttackBot]} ({playerTeam}) {deathPlayer[whomAttackBot]}");
                //--------------------------------------------------------------------------------------------------------------------------------------------
                Console.WriteLine($"Команда {playerTeam}: ");
                Console.WriteLine("==========================================");
                for (int i = 0; i < manuHeroes; i++)
                {
                    Console.WriteLine($"{i + 1}. {playerHeroes[i]} ({playerHeroesHP[i]}HP), базовый урон: {playerHeroesDamage[i]} {deathPlayer[i]}");
                }
                Console.WriteLine("==========================================\n\n\n");
                Console.WriteLine($"Команда {botTeam}: ");
                Console.WriteLine("==========================================");
                for (int i = 0; i < manuHeroes; i++)
                {
                    Console.WriteLine($"{i + 1}. {botHeroes[i]} ({botHeroesHP[i]}HP), базовый урон: {botHeroesDamage[i]} {deathBot[i]}");
                }
                Console.WriteLine("==========================================");
                botGeneralHP = 0;
                playerGeneralHP = 0;
                for (int i = 0; i < manuHeroes; i++)
                {
                    botGeneralHP += botHeroesHP[i];
                    playerGeneralHP += playerHeroesHP[i];
                }
                if (playerGeneralHP == 0 || botGeneralHP == 0)
                {
                    inGame = false;
                }
            }
        }
        static void endGame()
        {
            Console.Clear();
            if (botGeneralHP == 0 && playerGeneralHP==0)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("НИЧЬЯ");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                if (botGeneralHP==0)
                {
                    Console.ForegroundColor = ConsoleColor.Green; 
                    Console.WriteLine($"Победила команда {playerTeam}");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else 
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Победила команда {botTeam}");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }
        static void Main(string[] args)
        {

            // Подготовка к игре
            startGame();
            //ход игры 
            mainGame();
            //Конец игры
            endGame();
        }
    }
}