using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Book
    {
        private string name;
        private Title title;
        private Author author;
        private Content content;

        public string Title { set { title.Name = value; } }
        public string Author { set { author.Name = value; } }
        public string Content { set { content.Name = value; } }

        public void Initialize()
        {
            title = new Title();
            author = new Author();
            content = new Content();
        }
        public Book(string name)
        {
            Initialize();
            this.name = name;
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
          
            Console.WriteLine("Name: " + name);
            title.Show();
            author.Show();
            content.Show();
        }
    }
}
