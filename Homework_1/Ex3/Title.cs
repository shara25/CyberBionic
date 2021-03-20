using System;
using System.Collections.Generic;
using System.Text;

//  Создать класс Book. Создать классы Title, Author и Content, каждый из которых должен содержать одно
//  строковое поле и метод void Show().
//  Реализуйте возможность добавления в книгу названия книги, имени автора и содержания.
//  Выведите на экран разными цветами при помощи метода Show() название книги, имя автора и содержание.

namespace Ex3
{
    class Title
    {
        private string label;
        public string Label
        {
            get
            {
                return label;
            }
            set
            {
                label = value;
            }
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(Label);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        
    }
}
