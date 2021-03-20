using System;
using System.Collections.Generic;
using System.Text;

//  Класс Point должен содержать два целочисленных поля и одно строковое поле. √

//  Создать три свойства с одним методом доступа get.√

//  Создать пользовательский конструктор, в теле которого проинициализируйте поля значениями
//  аргументов. Класс Figure должен содержать конструкторы, которые принимают от 3-х до 5-ти аргументов типа Point.

//  Создать два метода: double LengthSide(Point A, Point B), который рассчитывает длину
//  стороны многоугольника; void PerimeterCalculator(), который рассчитывает периметр многоугольника.

//  Написать программу, которая выводит на экран название и периметр многоугольника.

namespace Ex4
{
    class Point
    {   // координаты точек
        private double pointX, pointY; 
        private string name;

        public double PointX 
        { 
            get
            {
                return pointX;
            }
         }
        public double PointY
        { 
            get
            {
                return pointY;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
        }

        public Point (double pointX, double pointY, string name)
        {
            this.pointX = pointX;
            this.pointY = pointY;
            this.name = name;
        }
    }
}
