using System;
using System.Collections.Generic;
using System.Text;

/*
Создайте перечисление, в котором будут содержаться должности сотрудников как имена констант.
Присвойте каждой константе значение, задающее количество часов, которые должен отработать
сотрудник за месяц.
*/

namespace Ex3
{
    enum Sotrudniki : uint //часы работы не могут быть отрицательные
    {
        Rabotyaga = 64,
        Nachalnik = 50,
        Glavniy = 40,
        Boss = 10
    }
}
