using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Чистый код")
            {
                Title = "Создание  анализ и рефакторинг",
                Author = "Роберт Мартин",
                Content = "Clean Code"

            };

            book.Show();
            Console.ReadKey();
        }
    }
}
