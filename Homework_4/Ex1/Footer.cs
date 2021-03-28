using System;

namespace Classes
{
    class Footer : Document
    {

        public Footer(string content) : base(content)
        {

        }

        public override void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(Content);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
