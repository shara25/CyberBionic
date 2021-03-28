using System;
using System.Collections.Generic;
using System.Text;

/*
В каждом из интерфейсов создайте по 3 метода void Play() / void Pause() / void Stop().
*/

namespace Ex3
{
    public interface IPlayable
    {
        void Play();
        void Pause();
        void Stop();
       
    }
}
