using System;
using System.Text;

namespace Classes
{
    abstract class Document
    {
        public string Content { get; set; }

        public Document(string content)
        {
            Content = content;
        }

        public virtual void Show()
        {
            Console.WriteLine(Content);
        }
    }
}
