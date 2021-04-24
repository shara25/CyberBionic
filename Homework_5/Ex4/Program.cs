using System;

/*
Создать класс Article, содержащий следующие закрытые поля:
• название товара;
• название магазина, в котором продается товар;
• стоимость товара в гривнах.
Создать класс Store, содержащий закрытый массив элементов типа Article.
Обеспечить следующие возможности:
• вывод информации о товаре по номеру с помощью индекса;
• вывод на экран информации о товаре, название которого введено с клавиатуры, если таких товаров нет,
выдать соответствующее сообщение;
Написать программу, вывода на экран информацию о товаре.
*/

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            Article book = new Article("Qwerty", "booklya", 100);
            Article coopy = new Article("Qwerty", "booklya", 100);

            Store store1 = new Store(book, coopy);
            Console.WriteLine(store1[0]);

            Console.WriteLine(store1[Console.ReadLine()]);
        }
    }
}
