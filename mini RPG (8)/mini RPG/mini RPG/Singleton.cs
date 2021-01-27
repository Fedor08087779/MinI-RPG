using System;
using System.Collections.Generic;
using System.Text;

namespace mini_RPG
{
    class Singleton
    {
        private static Singleton random;
        private Singleton()
        {
        }
        public Random Random { get; set; }
        public static Singleton getRandom()
        {
            if (random == null)
                random = new Singleton();
            return random;
        }
        public void RandomNumber()
        {
            int calculationNumber = random.Next();
        }
    }
}