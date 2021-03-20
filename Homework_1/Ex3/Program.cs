using System;

//  Создать класс Book. Создать классы Title, Author и Content,√
//  каждый из которых должен содержать одно строковое поле и метод void Show().√
//  Реализуйте возможность добавления в книгу названия книги, имени автора и содержания.
//  Выведите на экран разными цветами при помощи метода Show() название книги, имя автора и содержание.

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Book smth = new Book("C# 4.0");
            smth.Author = "Герберт Шилдт";
            smth.Content = "Полное описание";
            smth.Title = "Полное руководство";

            smth.Show();

            // Delay.
            Console.ReadKey();
        }
    }
}
