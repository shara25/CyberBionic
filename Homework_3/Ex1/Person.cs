using System;
using System.Collections.Generic;
using System.Text;

namespace Ex1
{
    class Person : Printer
    {
        public override void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(value);


        }
    }
}
