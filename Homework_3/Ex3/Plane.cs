using System;
using System.Collections.Generic;
using System.Text;

namespace Ex3
{
    class Plane : Vehicle
    {
        public double High { get; set; }
        public int Passengers { get; set; }
        public Plane(string coordinates, double cost, double speed, string yearOfIssue, double high, int passengers) : base(coordinates, cost, speed, yearOfIssue)
        {
            High = high;
            Passengers = passengers;
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine("Самолет летит на высоте: " + High);
            Console.WriteLine("В самолете летит пассажиров: " + Passengers);
        }
    }
}
