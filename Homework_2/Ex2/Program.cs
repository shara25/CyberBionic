using System;

//  Создать класс Converter.
//  В теле класса создать пользовательский конструктор, который принимает три вещественных аргумента, и
//  инициализирует поля соответствующие курсу 3-х основных валют, по отношению к гривне – public
//  Converter(double usd, double eur, double rub).
//  Написать программу, которая будет выполнять конвертацию из гривны в одну из указанных валют, также
//  программа должна производить конвертацию из указанных валют в гривну.

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            double usd = 0; double eur = 0; double rub = 0; double grn = 0;
            string choice = null;

            Console.WriteLine("Вы хотите купить валюту или обменять на гривны?\nЕсли хотите купить, то напишите <купить>, если продать, то <продать>");
            string operation = Console.ReadLine();
            
            Converter converter = new Converter(usd, eur, rub);
            if (operation == "купить") // купить доллары, евро, рубли
            {
                Console.WriteLine("Какую валюту Вы хотите приобрести?\nЕсли хотите купить доллары, то напишите <доллар>, если евро, то <евро>, если рубли, то <рубли> ");
                choice = Console.ReadLine();
                Console.WriteLine("Укажите сумму в гривнах");
                grn = double.Parse(Console.ReadLine());
                switch (choice)
                {
                    case "доллар":
                        {
                            double summ = converter.ConvertToUsd(grn);
                            Console.WriteLine("Вы обменяли: " +grn + " на столько " + summ + " долларов");
                            return;
                        }
                    case "евро":
                        {
                            double summ = converter.ConvertToEur(grn);
                            Console.WriteLine("Вы обменяли: " + grn + " на столько " + summ + " евро");
                            return;
                        }
                    case "рубли":
                        {
                            double summ = converter.ConvertToRub(grn);
                            Console.WriteLine("Вы обменяли: " + grn + " на столько " + summ + " рублей");
                            return;
                        }
                    default:
                        {
                            Console.WriteLine("Такой валюты не существует, попробуйте еще раз.");
                            return;
                        }
                }
            }
            else if(operation == "продать") // купить гривны
            {
                Console.WriteLine("Какую валюту хотите обменять?");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "доллар":
                        {
                            Console.WriteLine("Веедите сумму долларов:");
                            usd = double.Parse(Console.ReadLine());
                            double summ = converter.ConvertFromUsd(usd);
                            Console.WriteLine("Вы обменяли: " + usd + " на столько " + summ + " гривен");
                            return;
                        }
                    case "евро":
                        {
                            Console.WriteLine("Веедите сумму евро:");
                            eur = double.Parse(Console.ReadLine());
                            double summ = converter.ConvertFromEur(eur);
                            Console.WriteLine("Вы обменяли: " + eur + " на столько " + summ + " гривен");
                            return;
                        }
                    case "рубли":
                        {
                            Console.WriteLine("Веедите сумму рублей:");
                            rub = double.Parse(Console.ReadLine());
                            double summ = converter.ConvertFromRub(rub);
                            Console.WriteLine("Вы обменяли: " + rub + " на столько " + summ + " гривен");
                            return;
                        }
                    default:
                        {
                            Console.WriteLine("Такой валюты не существует, попробуйте еще раз.");
                            return;
                        }
                }
            }
            else
            {
                throw new Exception("Неверная операция");
            }
           
        }
    }
}
