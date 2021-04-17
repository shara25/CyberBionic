using System;
using System.Collections.Generic;
using System.Text;

/*
Создайте класс Accountant с методом bool AskForBonus(Post worker, int hours), отражающее
давать или нет сотруднику премию. Если сотрудник отработал больше положенных часов в месяц, то ему
положена премия.
*/

namespace Ex3
{
    class Accountant
    {
        public int Hours { get; set; }
      
        public bool AskForBonus(Sotrudniki worker, int hours)
        {

            if (worker == Sotrudniki.Boss && Hours >= 10)
            {
                { return true; }
            }

            else if (worker == Sotrudniki.Glavniy && Hours >= 40)
            {
                { return true; }
            }
            else if (worker == Sotrudniki.Nachalnik && Hours >= 50)
            {
                { return true; }
            }
            else if (worker == Sotrudniki.Rabotyaga && Hours >= 64)
            {
                { return true; }
            }
            else return false;

        }
    }
}
