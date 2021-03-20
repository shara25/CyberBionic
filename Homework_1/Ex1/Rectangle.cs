using System;
using System.Collections.Generic;
using System.Text;

//  Требуется: Создать класс с именем Rectangle.
//  В теле класса создать два поля, описывающие длины сторон double side1, side2.

//  Создать пользовательский конструктор Rectangle(double side1, double side2), в теле которого
//  поля side1 и side2 инициализируются значениями аргументов.

//  Создать два метода, вычисляющие площадь прямоугольника - double AreaCalculator() и периметр
//  прямоугольника - double PerimeterCalculator().

//  Создать два свойства double Area и double Perimeter с одним методом доступа get.
//  Написать программу, которая принимает от пользователя длины двух сторон прямоугольника и выводит
//  на экран периметр и площадь.

namespace Ex1
{
    class Rectangle
    {
        private double side1, side2;
        
        // Свойства для каждого поля (можно было поля не объявлять, автосвойства сами их создают)
        public double Side1 { get;}
        public double Side2 { get;}

        // Создаем пользовательский конструктор который принимает два аргумента side1, side2
        public Rectangle (double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }

        // Создаем методы
        public double AreaCalculator(double side1,double side2)
        {
            double area = side1 * side2;
            return area;
        }

        public double PerimeterCalculator(double side1, double side2)
        {
            double perimetr = side1 + side2;
            return perimetr;
        }

        //  Создать два свойства double Area и double Perimeter с одним методом доступа get.

        public double Area { get; set; }
        public double Perimetr { get; set; }

    }
}
