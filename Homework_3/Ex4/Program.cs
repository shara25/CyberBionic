using System;

/*
Создайте класс DocumentWorker.
В теле класса создайте три метода OpenDocument(), EditDocument(), SaveDocument().
В тело каждого из методов добавьте вывод на экран соответствующих строк: "Документ открыт",
"Редактирование документа доступно в версии Про", "Сохранение документа доступно в
версии Про".
Создайте производный класс ProDocumentWorker.
Переопределите соответствующие методы, при переопределении методов выводите следующие строки:
"Документ отредактирован", "Документ сохранен в старом формате, сохранение в остальных
форматах доступно в версии Эксперт".
Создайте производный класс ExpertDocumentWorker от базового класса ProDocumentWorker.
Переопределите соответствующий метод. При вызове данного метода необходимо выводить на экран
"Документ сохранен в новом формате".
В теле метода Main() реализуйте возможность приема от пользователя номера ключа доступа pro и exp.
Если пользователь не вводит ключ, он может пользоваться только бесплатной версией (создается
экземпляр базового класса), если пользователь ввел номера ключа доступа pro и exp, то должен
создаться экземпляр соответствующей версии класса, приведенный к базовому – DocumentWorker.
*/

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        { 
            // 0 - бесплатная версия, 1 - Про версия, 2- Експерт версия

            Console.WriteLine("Введите ключ доступа");
            int key = int.Parse(Console.ReadLine());

            if (key == 0)
            {
                DocumentWorker documentWorker = new DocumentWorker();
                documentWorker.OpenDocumnet();
                documentWorker.EditDocumnet();
                documentWorker.SaveDocumnet();
            }
            else if (key == 1)
            {
                DocumentWorker documentWorker = new ProDocumentWorker();
                documentWorker.OpenDocumnet();
                documentWorker.EditDocumnet();
                documentWorker.SaveDocumnet();
            }
            else if (key == 2)
            {
                ProDocumentWorker documentWorker = new ExpertDocumentWorker();
                documentWorker.OpenDocumnet();
                documentWorker.EditDocumnet();
                documentWorker.SaveDocumnet();
            }
            else
            {
                Console.WriteLine("Неверно указанный ключ");
            }

            

            Console.WriteLine();
        }
    }
}
