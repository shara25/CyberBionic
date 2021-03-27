using System;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            string cord = "0.0";
            double cost = 10000;
            double speed = 60.0;
            string year = "1995";

            Vehicle vehicle = new Car(cord, cost, speed, year);

            vehicle.Show();
            Console.WriteLine(new string('*', 80));

            cord = "10.54";
            cost = 1000000;
            double high = 10;
            int passengers = 4;
            Vehicle vehicle1 = new Plane(cord, cost, speed, year, high, passengers);
            vehicle1.Show();
            Console.WriteLine(new string('*', 80));

            string port = "ganduras";
            Vehicle vehicle2 = new Ship(cord, cost, speed, year, passengers, port);
            vehicle2.Show();
            Console.WriteLine(new string('√', 80));
        }
    }
}
