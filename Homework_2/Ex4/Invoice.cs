using System;
using System.Collections.Generic;
using System.Text;

//  Создать класс Invoice.
//  В теле класса создать три поля int account, string customer, string provider, которые должны быть
//  проинициализированы один раз (при создании экземпляра данного класса) без возможности их
//  дальнейшего изменения.
//  В теле класса создать два закрытых поля string article, int quantity
//  Создать метод расчета стоимости заказа с НДС и без НДС.
//  Написать программу, которая выводит на экран сумму оплаты заказанного товара с НДС или без НДС.

namespace Ex4
{
    class Invoice
    {
        public readonly int account;
        public string customer, provider;
        private string article; // название
        private int quantity; // количество

        public int Account
        {
            get
            {
                return quantity;
            }
            set
            {
                if (account < 0)
                {
                    Console.WriteLine("Ошибка");
                    return;
                }
            }
        }
        public string Customer
        {
            get
            {
                return customer;
            }
            set
            {
                if (customer == null)
                {
                    Console.WriteLine("Ошибка");
                    return;
                }
            }
        }
        public string Provider
        {
            get
            {
                return provider;
            }
            set
            {
                if (provider == null)
                {
                    Console.WriteLine("Ошибка");
                    return;
                }
            }
        }

        public string Article
        {
            get
            {
                return article;
            }
            set
            {
                if (article == null)
                {
                    Console.WriteLine("Название не может быть пустым");
                    return;
                }
                article = value;
            }
        }
        public int Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                if (quantity < 0)
                {
                    Console.WriteLine("Количество не может быть отрицательным");
                    return;
                }
                quantity = value;
            }
        }

        public Invoice (int account,string customer, string provider, int quantity, string article)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
            this.quantity = quantity;
            this.article = article;
        }
        
        //  Создать метод расчета стоимости заказа с НДС и без НДС.

        public double OrderWithNds (int quantity,double cost)
        {
            double rent = cost * 0.2;
            double sum = (cost + rent) * quantity;
            return sum;
        }
        public double OrderWithoutNds(int quantity, double cost)
        {
            double sum = cost * quantity;
            return sum;
        }

        //  Написать программу, которая выводит на экран сумму оплаты заказанного товара с НДС или без НДС.
    }
}
