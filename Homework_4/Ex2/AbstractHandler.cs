using System;
using System.Collections.Generic;
using System.Text;

// Создайте класс AbstractHandler.
// В теле класса создать методы void Open(), void Create(), void Chenge(), void Save().

namespace Ex2
{
    abstract class AbstractHandler
    {
        public abstract void Open();

        public abstract void Create();


        public abstract void Change();

        public abstract void Save();

    }
}
