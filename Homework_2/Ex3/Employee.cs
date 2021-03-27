using System;
using System.Collections.Generic;
using System.Text;

//  Создать класс Employee.
//  В теле класса создать пользовательский конструктор, который принимает два строковых аргумента, и
//  инициализирует поля, соответствующие фамилии и имени сотрудника.
//  Создать метод рассчитывающий оклад сотрудника (в зависимости от должности и стажа) и налоговый сбор.
//  Написать программу, которая выводит на экран информацию о сотруднике (фамилия, имя, должность), оклад и налоговый сбор.

namespace Ex3
{
    class Employee
    {
        private string name, surname, position;

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
                    Console.WriteLine("Имя не может быть пустым");
                    //return;
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
                    Console.WriteLine("Фамилия не может быть пустой");
                    //return;
                }
                surname = value;
            }
        }
        public string Position
        {
            get
            {
                
                return position;
            }

            set
            {
                if (position == null)
                {
                    Console.WriteLine("Должность не может быть пустой");
                    //return;
                }
                position = value;
            }
        }

        public Employee (string name,string surname)
        {
            this.name = name;
            this.surname = name;
        }

        //  Создать метод рассчитывающий оклад сотрудника (в зависимости от должности и стажа) и налоговый сбор.
        public double Salary(double oklad, double lengthOfWork, double tax)
        {
            double salary =((oklad * lengthOfWork)*0.2) - (oklad * (tax / 100));
            return salary;
        }
        //  Написать программу, которая выводит на экран информацию о сотруднике (фамилия, имя, должность), оклад и налоговый сбор.
        public void Show()
        {
            Console.WriteLine("Имя сотрудника " + name + "\nФамилия сотрудника " + surname + "\nДолжность " + position);
        }
    }
}
