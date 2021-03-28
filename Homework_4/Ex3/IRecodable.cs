using System;
using System.Collections.Generic;
using System.Text;

/*
В каждом из интерфейсов создайте по 3 метода void
Play() / void Pause() / void Stop() и void Record() / void Pause() / void Stop() соответственно.
*/

namespace Ex3
{
    public interface IRecodable
    {
        void Record();
        void Pause();
        void Stop();
    }
}
