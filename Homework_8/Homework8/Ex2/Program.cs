using System;

/*
Создайте статический класс с методом void Print (string stroka, int color), который выводит на
экран строку заданным цветом. Используя перечисление, создайте набор цветов, доступных
пользователю. Ввод строки и выбор цвета предоставьте пользователю.
*/

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напишите что-то ");
            string @string = Console.ReadLine();
            Console.WriteLine("Выберите цвет: Red = 0,\nGreen = 1,\nYellow = 2,\nWhite = 3, \nBlack = 4");
            byte color = byte.Parse(Console.ReadLine());
            Class1 newstring = new Class1();
            newstring.Print(@string, color);
        }
    }
}
