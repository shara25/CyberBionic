using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
Cоздать массив размерностью N элементов, заполнить его произвольными целыми значениями.
Вывести наибольшее значение массива, наименьшее значение массива, общую сумму элементов,
среднее арифметическое всех элементов, вывести все нечетные значения.
*/

namespace Ex2
{
    class Indexer
    {
        private int[] array;
        public int Length;

        public Indexer()
        {

        }

        public Indexer (int size) //конструктор построения массива заданого размера
        {
            array = new int[size];
            Length = size;
        }

        public void AddRandom ()
        {
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(0, Length);
                Console.WriteLine(array[i] = rnd.Next(0, Length));
            }
            
        }

        public void MaxValue() // Нахождение максимального значения через сортировку (наибольший элемент будет последним)
        {
            Array.Sort(array);
            int max = array[Length - 1];
            Console.WriteLine("Наибольший элемент массива " + max);
        }

        public void MinValue() // Нахождение минимального значения через сортировку (наименьший элемент будет первым)
        {
            Array.Sort(array);
            int min = array[0];
            Console.WriteLine("Наименьший элемент массива " + min);
        }

        public void Summ()
        {
            int summ = 0;
            for (int i = 0; i < array.Length; i++)
            {
                summ += array[i];
            }
            Console.WriteLine("Сумма элементов равна " + summ);
        }

        public void Average()
        {
            int summ = 0;
            int average = 0;
            for (int i = 0; i < array.Length; i++)
            {
                summ += array[i];
            }
            average = summ / array.Length;
            Console.WriteLine("Среднее арифметическое равно " + average);
        }

        public void Odd()
        {
            for (int i = 0; i < array.Length; i++)
            {
                if ((array[i] % 2) != 0)
                {
                    Console.WriteLine("Нечетные элементы массива:");
                    Console.WriteLine(array[i]);
                }
            }
        }



        public int this[int index]
        {
            get
            {
                if (index >= 0 && index <= Length)
                {
                    return array[index];
                }
                else
                {
                    return -1;
                }
            }
            set
            { array[index] = value; }
        }
    }
}
