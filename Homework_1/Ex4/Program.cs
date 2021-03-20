using System;

//  Создать классы Point и Figure.√

//  Класс Point должен содержать два целочисленных поля и одно строковое поле.

//  Создать три свойства с одним методом доступа get.

//  Создать пользовательский конструктор, в теле которого проинициализируйте поля значениями
//  аргументов. Класс Figure должен содержать конструкторы, которые принимают от 3-х до 5-ти аргументов типа Point.

//  Создать два метода: double LengthSide(Point A, Point B), который рассчитывает длину
//  стороны многоугольника; void PerimeterCalculator(), который рассчитывает периметр многоугольника.
//  Написать программу, которая выводит на экран название и периметр многоугольника.

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координаты стороны многоугольника");
            Console.WriteLine("Координата Х первой точки:");
            double pointX = double.Parse(Console.ReadLine());
            Console.WriteLine("Координата Y первой точки:");
            double pointY = double.Parse(Console.ReadLine());
            Console.WriteLine("Дайте название точке:");
            string name = Console.ReadLine();


            Point pointOne = new Point(pointX, pointY, name);
            Console.WriteLine("Координата Х второй точки:");
            pointX = double.Parse(Console.ReadLine());
            Console.WriteLine("Координата Y второй точки:");
            pointY = double.Parse(Console.ReadLine());
            Console.WriteLine("Дайте название точке:");
            name = Console.ReadLine();

            Point pointTwo = new Point(pointX, pointY, name);
            Console.WriteLine("Координата Х третьей точки:");
            pointX = double.Parse(Console.ReadLine());
            Console.WriteLine("Координата Y третьей точки:");
            pointY = double.Parse(Console.ReadLine());
            Console.WriteLine("Дайте название точке:");
            name = Console.ReadLine();

            Point pointThree = new Point(pointX, pointY, name);
            

            Figure figureOne = new Figure(pointOne, pointTwo, pointThree);
            figureOne.LengthSide(pointOne,pointTwo);
            Console.WriteLine(figureOne.PerimeterCalculator());

            Console.ReadKey();
        }
    }
}
