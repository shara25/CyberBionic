using System;

//  Создать класс Invoice.
//  В теле класса создать три поля int account, string customer, string provider, которые должны быть
//  проинициализированы один раз (при создании экземпляра данного класса) без возможности их
//  дальнейшего изменения.
//  В теле класса создать два закрытых поля string article, int quantity
//  Создать метод расчета стоимости заказа с НДС и без НДС.
//  Написать программу, которая выводит на экран сумму оплаты заказанного товара с НДС или без НДС.

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите стоимость товара: ");
            double cost = double.Parse(Console.ReadLine());
            Invoice invoice = new Invoice(1,"Задорожный Владимир","Зиноида Петровна",5,"Герберт Шилдт С#");
            Console.WriteLine("К оплате с учетом НДС " + invoice.OrderWithNds(5, cost));
            Console.WriteLine("К оплате с учетом НДС " + invoice.OrderWithoutNds(5, cost));
        }
    }
}
