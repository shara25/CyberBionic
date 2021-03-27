using System;
using System.Collections.Generic;
using System.Text;

/*
Создайте производный класс ExpertDocumentWorker от базового класса ProDocumentWorker.
Переопределите соответствующий метод. При вызове данного метода необходимо выводить на экран
"Документ сохранен в новом формате".
*/

namespace Ex4
{
    class ExpertDocumentWorker : ProDocumentWorker
    {
        public override void SaveDocumnet()
        {
            Console.WriteLine("Документ сохранен в новом формате");
        }
    }
}
