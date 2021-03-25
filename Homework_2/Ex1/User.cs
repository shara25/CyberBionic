using System;
using System.Collections.Generic;
using System.Text;

//  Создать класс User, содержащий информацию о пользователе (логин, имя, фамилия, возраст, дата
//  заполнения анкеты). Поле дата заполнения анкеты должно быть проинициализировано только один раз
//  (при создании экземпляра данного класса) без возможности его дальнейшего изменения.
//  Реализуйте вывод на экран информации о пользователе.

namespace Ex1
{
    class User
    {
        private string login;
        private string name;
        private string surname;
        private int age;
        private string dateOfFilling;

        public string Login
        {
            get
            {
                return login;
            }

            set
            {   if(login == null)
                {
                    Console.WriteLine("поле login не может быть пустым");
                    return;
                }
                login = value;
            }

        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                if (name == null)
                {
                    Console.WriteLine("поле name не может быть пустым");
                    return;
                }
                name = value;
            }
        }

        public string Surname
        {
            get
            {
               return surname;
            }

            set
            {
                if (surname == null)
                {
                    Console.WriteLine("поле surname не может быть пустым");
                    return;
                }
                surname = value;
            }
        }

        public int Age
        {
            get
            {
             return age;
            }

            set
            {
                if (age == 0 || age < 0)
                {
                    Console.WriteLine("поле age не может быть равным или меньше нуля");
                    return;
                }
                age = value;
            }
        }

        public string DateOfFilling
        {
            get
            {
                if (dateOfFilling == null)
                    Console.WriteLine("поле dateOfFilling не может быть пустым");

                return dateOfFilling;
            }

            set
            {
                dateOfFilling = value;
            }
        }

        public User()
        {

        }
        public User(string login, string name, string surname, int age, string dateOfFilling)
        {
            this.login = login;
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.dateOfFilling = dateOfFilling;
        }

        //public void UserShow(string login, string name, string surname, int age, string dateOfFilling)
        //{
        //    Console.WriteLine("Логин пользователя : " + login + "\n Имя пользователя: " + name + "\n Фамилия пользователя: " + surname + "\n Возраст пользователя: " + age + "Дата заполнения анкеты: " + dateOfFilling);
        //}
        public void UserShow()
        {
            Console.WriteLine("Логин пользователя : " + login + "\nИмя пользователя: " + name + "\nФамилия пользователя: " + surname + "\nВозраст пользователя: " + age + "\nДата заполнения анкеты: " + dateOfFilling);
        }

    }
   
}
