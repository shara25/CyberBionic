using System;

/*
 Создать класс MyMatrix, обеспечивающий представление матрицы произвольного размера с
возможностью изменения числа строк и столбцов.
Написать программу, которая выводит на экран матрицу и производные от нее матрицы разных порядков.
*/

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMatrix matrix = new MyMatrix(5, 5);

            matrix.FeedMatrix();
            matrix.ShowMatrix();
            Console.WriteLine(new string('-', 0));

            matrix.ChangeMatrix(3, 3);
            matrix.FeedMatrix();
            matrix.ShowMatrix();



        }
    }
}
