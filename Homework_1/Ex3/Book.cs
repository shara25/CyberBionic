using System;
using System.Collections.Generic;
using System.Text;

namespace Ex3
{
    class Book
    {
        Author author = null;
        Content content = null;
        Title title = null;

        void InitializeDocument()
        {
            this.author = new Author();
            this.content = new Content();
            this.title = new Title();
        }
        public Book(string title)
        {
            InitializeDocument();
            this.title.Label = title;
        }
        public void Show()
        {
            this.author.Show();
            this.content.Show();
            this.title.Show();
        }
        public string Author
        {
            set
            {
                this.author.Name = value;
            }
        }
        public string Content
        {
            set 
            {
                this.content.Text = value;
            }
        }
        public string Title
        {
            set
            {
                this.title.Label = value;
            }
        }
    }
}
