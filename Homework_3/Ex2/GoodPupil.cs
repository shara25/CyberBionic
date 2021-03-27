using System;
using System.Collections.Generic;
using System.Text;

namespace Ex2
{
    class GoodPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Я хорошо учусь");
        }
        public override void Read()
        {
            Console.WriteLine("Я хорошо читаю");
        }
        public override void Write()
        {
            Console.WriteLine("Я хорошо пишу");
        }
        public override void Relax()
        {
            Console.WriteLine("Иногда могу погулять с друзьями");
        }
    }
}
