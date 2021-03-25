using System;

//  Создать класс User, содержащий информацию о пользователе (логин, имя, фамилия, возраст, дата
//  заполнения анкеты). Поле дата заполнения анкеты должно быть проинициализировано только один раз
//  (при создании экземпляра данного класса) без возможности его дальнейшего изменения.
//  Реализуйте вывод на экран информации о пользователе.

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        { 
            // Констурктор по умолчанию
            User userMaxim = new User();
            userMaxim.Login = "SHARA25";
            userMaxim.Name = "Максим";
            userMaxim.Surname = "Бороу";
            userMaxim.Age = 25;
            userMaxim.DateOfFilling = "24.03.2021";

            userMaxim.UserShow();

            Console.WriteLine(new string('-', 50));

            //  Пользовательский конструктор
            User secondUser = new User("Kakao", "Володя", "Бизон", 22, "24.03.2021");
            secondUser.UserShow();

            Console.WriteLine(new string('-', 50));

            User parseUser = new User();
            Console.WriteLine("Введите логин");
            parseUser.Login = Console.ReadLine();

            Console.WriteLine("Введите имя");
            parseUser.Name = Console.ReadLine();

            Console.WriteLine("Введите фамилию");
            parseUser.Surname = Console.ReadLine();

            Console.WriteLine("Введите возраст");
            parseUser.Age = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите дату заполнения");
            parseUser.DateOfFilling = Console.ReadLine();

            Console.WriteLine(new string('-', 50));
            parseUser.UserShow();



        }
    }
}
