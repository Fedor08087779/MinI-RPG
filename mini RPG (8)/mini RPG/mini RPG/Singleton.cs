using System;
using System.Collections.Generic;
using System.Text;

namespace mini_RPG
{
    class Singleton
    {
        private static Singleton random;
        Random generator = new Random();
        Singleton singleton = new Singleton(0, 0);
        public int fromNumber { get; set; }
        public int beforeNumber { get; set; }
        private Singleton(int _fromNumber,int  _beforeNumber)
        {
            fromNumber = _fromNumber;
            beforeNumber = _beforeNumber;
        }
        public Random Random { get; set; }
        public static Singleton GetRandom()
        {
            if (random == null)
                random = new Singleton(0,0);
            return random;
        }
        public int RandomNumber()
        {
            int calculationNumber = generator.Next(fromNumber, beforeNumber);
            return calculationNumber;
        }
    }
}