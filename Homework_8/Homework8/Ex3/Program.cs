using System;

/*
Создайте перечисление, в котором будут содержаться должности сотрудников как имена констант.
Присвойте каждой константе значение, задающее количество часов, которые должен отработать
сотрудник за месяц.
Создайте класс Accountant с методом bool AskForBonus(Post worker, int hours), отражающее
давать или нет сотруднику премию. Если сотрудник отработал больше положенных часов в месяц, то ему
положена премия.
*/

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Accountant acc = new Accountant();
            acc.Hours = 5;
            bool premiya = acc.AskForBonus(Sotrudniki.Boss, acc.Hours);
            if (premiya)
            {
                Console.WriteLine("Можно выдать премию");
            }
            else Console.WriteLine("Недостаточно часов");

        }
    }
}
