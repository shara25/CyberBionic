using System;
using System.Collections.Generic;
using System.Text;

//  Создать пользовательский конструктор, в теле которого проинициализируйте поля значениями
//  аргументов. Класс Figure должен содержать конструкторы, которые принимают от 3-х до 5-ти аргументов типа Point.

//  Создать два метода: double LengthSide(Point A, Point B), который рассчитывает длину
//  стороны многоугольника; void PerimeterCalculator(), который рассчитывает периметр многоугольника.

//  Написать программу, которая выводит на экран название и периметр многоугольника.

namespace Ex4
{
    class Figure
    {
        Point[] arr;
        
        // public string Name { get; set; }

        public Figure(Point point1,Point point2, Point point3)
        {
           arr = new Point [] { point1, point2, point3};
        }

        public Figure(Point point1, Point point2, Point point3, Point point4)
        {
            arr = new Point [] { point1, point2, point3, point4};
        }
        // point1(x;y)
        public Figure(Point point1, Point point2, Point point3, Point point4, Point point5)
        {
            arr = new Point [] { point1, point2, point3, point4, point5 };
        }
         
        public double LengthSide(Point point1, Point point2)
        { // sqrt((X2-X1))^2 + (Y2-Y1)^2)
            double resultX = point2.PointX - point1.PointX;
            double resultY = point2.PointY - point1.PointY;
            double length = Math.Sqrt(Math.Pow((resultX), 2) + Math.Pow((resultY), 2));
            return length;
        }
        public double PerimeterCalculator()
        {
            double summ = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if ((i+1)<arr.Length)
                {
                    summ += LengthSide(arr[i], arr[i + 1]);
                }
                else
                {
                    summ += LengthSide(arr[i], arr[0]);
                }
                
            }
            return summ;
        }

    }
}
