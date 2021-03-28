using System;

namespace Classes
{
    class Title : Document
    {
        public Title(string content) : base(content)
        {

        }

        public override void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(Content);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
