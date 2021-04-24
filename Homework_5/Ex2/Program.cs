using System;
/*
Cоздать массив размерностью N элементов, заполнить его произвольными целыми значениями.
Вывести наибольшее значение массива, наименьшее значение массива, общую сумму элементов,
среднее арифметическое всех элементов, вывести все нечетные значения.
*/

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Indexer array = new Indexer(15);
            array.AddRandom();
            Console.WriteLine(new string ('*', 80));
            array.MaxValue();
            Console.WriteLine(new string('*', 80));
            array.MinValue();
            Console.WriteLine(new string('*', 80));
            array.Summ();
            Console.WriteLine(new string('*', 80));
            array.Average();
            Console.WriteLine(new string('*', 80));
            array.Odd();


        }
    }
}
