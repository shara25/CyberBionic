using System;

//  Создать класс Employee.
//  В теле класса создать пользовательский конструктор, который принимает два строковых аргумента, и
//  инициализирует поля, соответствующие фамилии и имени сотрудника.
//  Создать метод рассчитывающий оклад сотрудника (в зависимости от должности и стажа) и налоговый сбор.
//  Написать программу, которая выводит на экран информацию о сотруднике (фамилия, имя, должность),
//  оклад и налоговый сбор.

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = null; string surname = null; 
            
            Employee firstEmployee = new Employee(name, surname);

            Console.WriteLine("Введите имя сотрудника");
            firstEmployee.Name = Console.ReadLine();

            Console.WriteLine("Введите фамилию сотрудника");
            firstEmployee.Surname = Console.ReadLine();

            Console.WriteLine("Введите должность сотрудника");
            firstEmployee.Position = Console.ReadLine();

            firstEmployee.Name = name;
            firstEmployee.Surname = surname;
            double salary = firstEmployee.Salary(12000, 5, 20);
            firstEmployee.Show();
            Console.WriteLine(salary);
        }
    }
}
