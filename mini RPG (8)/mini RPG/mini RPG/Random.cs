using System;
using System.Collections.Generic;
using System.Text;

namespace mini_RPG
{
    class Random
    {
        private static Random random;
        public Random Number { get; private set; }
        private Random()
        {
            Number = new Random();
        }
        public static Random GetRandom()
        {
            if (random == null)
                random = new Random();
            return random;
        }
    }
}