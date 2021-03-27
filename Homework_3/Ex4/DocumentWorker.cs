using System;
using System.Collections.Generic;
using System.Text;

/*Создайте класс DocumentWorker.
В теле класса создайте три метода OpenDocument(), EditDocument(), SaveDocument().
В тело каждого из методов добавьте вывод на экран соответствующих строк: "Документ открыт",
"Редактирование документа доступно в версии Про", "Сохранение документа доступно в
версии Про".
*/

namespace Ex4
{
    class DocumentWorker
    {
        public virtual void OpenDocumnet()
        {
            Console.WriteLine("Документ открыт");
        }
        public virtual void EditDocumnet()
        {
            Console.WriteLine("Редактирование документа доступно в версии Про");
        }
        public virtual void SaveDocumnet()
        {
            Console.WriteLine("Сохранение документа доступно в версии Про");
        }
    }
}
