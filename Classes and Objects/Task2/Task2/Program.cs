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

//Используя Visual Studio, создайте проект по шаблону Console Application.
//Требуется:
//Создать класс Book. Создать классы Title, Author и Content, каждый из которых должен содержать
//одно строковое поле и метод void Show().
//Реализуйте возможность добавления в книгу названия книги, имени автора и содержания.
//Выведите на экран разными цветами при помощи метода Show() название книги, имя автора и
//содержание