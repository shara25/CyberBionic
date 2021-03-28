using System;
using System.Collections.Generic;
using System.Text;

//Создайте производный класс Player от базовых интерфейсов IPlayable и IRecodable.

namespace Ex3
{
    class Player : IRecodable, IPlayable
    {
        public void Record()
        {
            Console.WriteLine("Идет запись");
        }
        public void Play()
        {
            Console.WriteLine("Воспроизведение");
        }
        public void Pause()
        {
            Console.WriteLine("Пауза");
        }
        public void Stop()
        {
            Console.WriteLine("Воспроизведение окончено");
        }
    }
}
