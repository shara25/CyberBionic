using System;

/*
Создайте 2 интерфейса IPlayable и IRecodable. В каждом из интерфейсов создайте по 3 метода void
Play() / void Pause() / void Stop() и void Record() / void Pause() / void Stop() соответственно.
Создайте производный класс Player от базовых интерфейсов IPlayable и IRecodable.
Написать программу, которая выполняет проигрывание и запись.
*/

namespace Ex3
{
    
    class Program
    {
        static void Main(string[] args)
        {

            IPlayable player = new Player();
            player.Play();
            player.Stop();
            player.Pause();
            Console.WriteLine(new string('*',80));

            IRecodable player1 = player as IRecodable;
            player1.Record();
            player1.Pause();
            player1.Stop();

        }
    }
}
