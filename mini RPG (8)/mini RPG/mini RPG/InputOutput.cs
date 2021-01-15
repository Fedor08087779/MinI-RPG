using System;
using System.Collections.Generic;
using System.Text;

namespace mini_RPG
{
    class InputOutput
    {
        public void Output(string value)
        {
            Console.Write(value);
        }
        public string Input()
        {
            return Console.ReadLine();
        }
    }
}
