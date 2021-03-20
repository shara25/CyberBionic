using System;

//  Создать класс с именем Address.
//  В теле класса требуется создать поля: index, country, city, street, house, apartment.Для каждого
//  поля, создать свойство с двумя методами доступа.
//  Создать экземпляр класса Address.
//  В поля экземпляра записать информацию о почтовом адресе.
//  Выведите на экран значения полей, описывающих адрес.

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Address address = new Address();
            {
                address.Index = "83012";
                address.Country = "Unkraine";
                address.City = "Doneck";
                address.Street = "SeeSharpStreet";
                address.House = "9.0";
                address.Apartament = "0";
                Console.WriteLine(address.Index + " " + address.Country + " " + address.City + " " + address.Street + " " + address.House  +" " + address.Apartament);      
            }
            //Delay
            Console.ReadKey();
        }
    }
}
