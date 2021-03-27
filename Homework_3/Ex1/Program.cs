using System;

/*  Создайте класс Printer.
  В теле класса создайте метод void Print(string value), который выводит на экран значение аргумента.
  Реализуйте возможность того, чтобы в случае наследования от данного класса других классов, и вызове
  соответствующего метода их экземпляра, строки, переданные в качестве аргументов методов, выводились разными цветами.
  Обязательно используйте приведение типов.
*/

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer printer = new Printer();
            string label = "Color printer";
            printer.Print(label);
            
            Animal animal = new Animal();
            label = "Color Animal";
            animal.Print(label);

            Person person = new Person();
            label = "Color Person";
            person.Print(label);

            Console.WriteLine(new string('-', 50));

            Printer printer1 = new Animal();
            label = "Color printer1";
            printer1.Print(label);

            Printer printer2 = new Person();
            label = "Color printer2";
            printer1.Print(label);
        }
    }
}
