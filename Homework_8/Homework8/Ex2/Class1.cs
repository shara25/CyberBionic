﻿using System;
using System.Collections.Generic;
using System.Text;

/*
Создайте статический класс с методом void Print (string stroka, int color), который выводит на
экран строку заданным цветом. Используя перечисление, создайте набор цветов, доступных
пользователю. Ввод строки и выбор цвета предоставьте пользователю.
*/

namespace Ex2
{
    enum colors : byte
    {
        Red = 1,
        Green = 2,
        Yellow = 3,
        White = 4,
        Black = 5
    }
    class Class1
    {
        public void Print(string @string, byte color)
        {
          
            switch (color)
            {
                case 1:
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(@string);
                        break;
                    }
                case 2:
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(@string);
                        break;
                    }
                case 3:
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(@string);
                        break;
                    }
                case 4:
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine(@string);
                        break;
                    }
                case 5:
                    {
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine(@string);
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }
    }
}
