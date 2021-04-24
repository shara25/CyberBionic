using Ex1;
using System;
using System.Text;
/*
Расширьте пример 5 (русско-английский словарь) еще и украинским словарем.
Реализуйте возможность поиска не только по ключевым русским словам и словам на остальных языках.
*/

namespace Indexers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Dictionary dictionary = new Dictionary();

            Console.WriteLine(dictionary["книга"]);
            Console.WriteLine(dictionary["дом"]);
            Console.WriteLine(dictionary["ручка"]);
            Console.WriteLine(dictionary["стол"]);
            Console.WriteLine(dictionary["карандаш"]);
            Console.WriteLine(dictionary["яблоко"]);
            Console.WriteLine(dictionary["солнце"]);

            Console.WriteLine(new string('-', 20));

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(dictionary[i]);
            }

            Console.WriteLine(new string('-', 50));

            Console.WriteLine(dictionary["олівець"]);
            Console.WriteLine(dictionary["стіл"]);
            Console.WriteLine(dictionary["яблуко"]);
            Console.WriteLine(dictionary["сонце"]);

            Console.WriteLine(new string('-', 80));

            Console.WriteLine(dictionary["pencil"]);
            Console.WriteLine(dictionary["table"]);
            Console.WriteLine(dictionary["apple"]);
            Console.WriteLine(dictionary["sun"]);


            // Delay.
            Console.ReadKey();
        }
    }
}
