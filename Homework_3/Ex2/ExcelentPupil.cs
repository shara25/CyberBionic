using System;
using System.Collections.Generic;
using System.Text;

namespace Ex2
{
    class ExcelentPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Я очень хорошо учусь");
        }
        public override void Read()
        {
            Console.WriteLine("Я очень хорошо читаю");
        }
        public override void Write()
        {
            Console.WriteLine("Я очень хорошо пишу");
        }
        public override void Relax()
        {
            Console.WriteLine("Я учусь даже когда отдыхаю");
        }
    }
}
