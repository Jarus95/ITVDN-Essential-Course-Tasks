using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Content
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Content Name: " + name);
        }
    }
}
