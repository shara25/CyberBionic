using System;
using System.Collections.Generic;
using System.Text;

namespace Ex2
{
    class ClassRoom : Pupil
    {
        public ClassRoom(Pupil pupil_1,Pupil pupil_2)
        {
            pupil_1.Study();
            pupil_1.Read();
            pupil_1.Write();
            pupil_1.Relax();

            Console.WriteLine(new string('*', 50));

            pupil_2.Study();
            pupil_2.Read();
            pupil_2.Write();
            pupil_2.Relax();

        }

        public ClassRoom(Pupil pupil_1, Pupil pupil_2,Pupil pupil_3)
        {
            pupil_1.Study();
            pupil_1.Read();
            pupil_1.Write();
            pupil_1.Relax();

            Console.WriteLine(new string('*', 50));

            pupil_2.Study();
            pupil_2.Read();
            pupil_2.Write();
            pupil_2.Relax();

            Console.WriteLine(new string('*', 50));

            pupil_3.Study();
            pupil_3.Read();
            pupil_3.Write();
            pupil_3.Relax();

        }
                
    }
}
