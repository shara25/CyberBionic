using System;
using System.Collections.Generic;
using System.Text;

namespace Ex1
{
    class Animal : Printer
    {
        public override void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(value);


        }
    }
}
