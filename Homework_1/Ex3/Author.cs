﻿using System;
using System.Collections.Generic;
using System.Text;

//  Создать класс Book. Создать классы Title, Author и Content, каждый из которых должен содержать одно
//  строковое поле и метод void Show().
//  Реализуйте возможность добавления в книгу названия книги, имени автора и содержания.
//  Выведите на экран разными цветами при помощи метода Show() название книги, имя автора и содержание.

namespace Ex3
{
    class Author
    {
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(Name);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
       


    }
}
