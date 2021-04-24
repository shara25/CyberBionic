using System;
using System.Text;
using System.Globalization;

/*
Реализуйте программу, которая будет принимать от пользователя дату его рождения и выводить
количество дней до его следующего дня рождения
*/

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            DateTime birthday = new DateTime(2021, 10, 15); // день рождения
            DateTime today = new DateTime(2021, 04, 17);
            Console.WriteLine("День рождения Максима " + birthday);

            Console.WriteLine(new string('-', 80));

            TimeSpan left = birthday - today;
            Console.WriteLine("Следующий день рождения через " + left.Days + " дней");
            double leftMonth = left.Days / 30;
            Console.WriteLine("Или через " + leftMonth + " месяцев");
            Console.Read();


        }
    }
}
