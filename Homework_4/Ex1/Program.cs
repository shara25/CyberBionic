using System;
using System.Text;

namespace Classes
{
    class Program
    {
        static void Main()
        {
            string content = null;

            Document title = new Title(content);
            title.Content = "Область в которой описывается заголовок";
            title.Show();

            Document body = new Body(content);
            body.Content = "Область в которой описывается тело документа";
            body.Show();

            Document footer = new Footer(content);
            footer.Content = "Нижняя часть документа";
            footer.Show();

            // Delay.
            Console.ReadKey();
        }
    }
}
