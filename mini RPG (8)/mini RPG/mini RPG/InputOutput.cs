using System;
using System.Collections.Generic;
using System.Text;

namespace mini_RPG
{
    class InputOutput
    {
        private static InputOutput instance;
        public string value { get; set; }
        private InputOutput()
        {
        }
        public static InputOutput getInstance()
        {
            if (instance == null)
                instance = new InputOutput();
            return instance;
        }
        public void Output(string value)
        {
            Console.Write(value);
        }
        public string Input()
        {
            return Console.ReadLine();
        }
        public int InputNumber()
        {
            string input = Console.ReadLine();
            bool success = int.TryParse(input, out int num);
            while(!success)
            {
                Console.WriteLine("Напиши ЧИСЛО!");
                input = Console.ReadLine();
                success = int.TryParse(input, out num);
            }
            return num;
        }
    }
}