using System;
using System.Collections.Generic;
using System.Text;

namespace Ex3
{
    class Ship : Vehicle
    {

        public string Port { get; set; }
        public int Passengers { get; set; }
        public Ship(string coordinates, double cost, double speed, string yearOfIssue, int passengers, string port) : base(coordinates, cost, speed, yearOfIssue)
        {
            Port = port;
            Passengers = passengers;
        }



        public override void Show()
        {
            base.Show();
            Console.WriteLine("Корабль находится в порту: " + Port);
            Console.WriteLine("В корабле пассажиров: " + Passengers);
        }
    }
}
