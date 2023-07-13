using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
  
            Book.Notes.Text = "Hello";
            Book.Notes.Text = "World";
            Console.WriteLine(Book.Notes.text);
            Console.WriteLine(new string('-', 40));
            FindAndReplaceManager.FindNext("Hello");

            Console.ReadKey();
        }
    }
}


//Используя Visual Studio, создайте проект по шаблону Console Application.
//Расширьте пример урока 005_Delegation, создав в классе Book, вложенный класс Notes, который
//позволит сохранять заметки читателя