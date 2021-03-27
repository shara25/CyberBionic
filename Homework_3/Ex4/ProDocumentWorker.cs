using System;
using System.Collections.Generic;
using System.Text;
/*
Создайте производный класс ProDocumentWorker.
Переопределите соответствующие методы, при переопределении методов выводите следующие строки:
"Документ отредактирован", "Документ сохранен в старом формате, сохранение в остальных
форматах доступно в версии Эксперт".
*/

namespace Ex4
{
    class ProDocumentWorker : DocumentWorker
    {
        public override void OpenDocumnet()
        {
            Console.WriteLine("Документ открыт");
        }
        public override void EditDocumnet()
        {
            Console.WriteLine("Документ отредактирован");
        }
        public override void SaveDocumnet()
        {
            Console.WriteLine("Документ сохранен в старом формате, сохранение в остальных форматах доступно в версии Эксперт");
        }
    }
}
