using System;

/*
Создайте класс AbstractHandler.
В теле класса создать методы void Open(), void Create(), void Chenge(), void Save().
Создать производные классы
XMLHandler,
TXTHandler,
DOCHandler
от базового класса
AbstractHandler.
Написать программу, которая будет выполнять определение документа и для каждого формата должны
быть методы открытия, создания, редактирования, сохранения определенного формата документа.
*/

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractHandler dOC = new DOCHandler();
            dOC.Create();
            dOC.Open();
            dOC.Change();
            dOC.Save();
            Console.WriteLine(new string('-',80));

            AbstractHandler dOC1 = new TXTHandler();
            dOC1.Create();
            dOC1.Open();
            dOC1.Change();
            dOC1.Save();
            Console.WriteLine(new string('-', 80));

            AbstractHandler dOC2 = new XMLHandler();
            dOC2.Create();
            dOC2.Open();
            dOC2.Change();
            dOC2.Save();
            Console.WriteLine(new string('-', 80));

        }
    }
}
