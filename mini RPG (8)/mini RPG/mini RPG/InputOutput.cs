using System;
using System.Collections.Generic;
using System.Text;

namespace mini_RPG
{
    class InputOutput
    {
        public char Value;
        public void Output()
        {
            Console.Write(Value);
        }
        public void Input()
        {
            Value = Console.ReadLine();
        }
    }
}
