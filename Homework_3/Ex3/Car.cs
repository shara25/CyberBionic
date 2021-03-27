using System;
using System.Collections.Generic;
using System.Text;

/*
Создать класс Vehicle.
В теле класса создайте поля: координаты и параметры средств передвижения (цена, скорость, год
выпуска).
Создайте 3 производных класса Plane, Саг и Ship.
Для класса Plane должна быть определена высота и количество пассажиров.
Для класса Ship — количество пассажиров и порт приписки.
Написать программу, которая выводит на экран информацию о каждом средстве передвижения.
*/

namespace Ex3
{
    class Car : Vehicle
    {
        public Car(string coordinates, double cost, double speed, string yearOfIssue) : base(coordinates, cost, speed, yearOfIssue)
        {
        }

        public override void Show()
        {
            base.Show();
        }

    }
}

