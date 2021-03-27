using System;
using System.Collections.Generic;
using System.Text;

/*  Создайте класс Printer.
  В теле класса создайте метод void Print(string value), который выводит на экран значение аргумента.
  Реализуйте возможность того, чтобы в случае наследования от данного класса других классов, и вызове
  соответствующего метода их экземпляра, строки, переданные в качестве аргументов методов, выводились разными цветами.
  Обязательно используйте приведение типов.
*/

namespace Ex1
{
    class Printer
    {
        
        public virtual void  Print (string value)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(value);
            

        }
    }
}
