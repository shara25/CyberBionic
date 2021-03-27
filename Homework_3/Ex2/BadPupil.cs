using System;
using System.Collections.Generic;
using System.Text;

namespace Ex2
{
    class BadPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Я забил на учебу");
        }
        public override void Read()
        {
            Console.WriteLine("Я не умею читать");
        }
        public override void Write()
        {
            Console.WriteLine("Я пишу с ошибками");
        }
        public override void Relax()
        {
            Console.WriteLine("Попиваю пивасик за гаражами");
        }
    }
}
