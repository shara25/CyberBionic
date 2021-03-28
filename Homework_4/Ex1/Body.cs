using System;

namespace Classes
{
    class Body : Document
    {

        public Body(string content): base (content)
        {
            
        }


        public override void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(Content);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
