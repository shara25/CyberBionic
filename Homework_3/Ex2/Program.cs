using System;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Pupil vasya = new BadPupil();
            Pupil fedya = new GoodPupil();
            Pupil dosya = new ExcelentPupil();
            
            ClassRoom Class_A = new ClassRoom(vasya, fedya);
            


        }
    }
}
