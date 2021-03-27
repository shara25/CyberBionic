using System;
using System.Collections.Generic;
using System.Text;

namespace Ex3
{
    class Vehicle
    {

        public string Coordinates { get; set; }
        public double Cost { get; set; }
        public double Speed { get; set; }
        public string YearOfIssue { get; set; }



        public Vehicle(string coordinates, double cost, double speed, string yearOfIssue)
        {
            Coordinates = coordinates;
            Cost = cost;
            Speed = speed;
            YearOfIssue = yearOfIssue;

        }

        public virtual void Show()
        {
            Console.WriteLine("Трансопртное средство находится в координатах: " + Coordinates);
            Console.WriteLine("Стоимость транспортного средства = " + Cost);
            Console.WriteLine("Скорость транспортного средства = " + Speed);
            Console.WriteLine("Год выпуска транспортного средства: " + YearOfIssue);
        }



    }
}
