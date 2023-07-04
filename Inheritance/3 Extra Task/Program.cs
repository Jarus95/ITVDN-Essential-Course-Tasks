using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Extra_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DerivedClass instance1 = new DerivedClass();
            instance1.Print("Hello World");

            Printer instance2  = instance1 as Printer;  //upcast
            instance2.Print("Hello World");

            DerivedClass instance3 = instance2 as DerivedClass; //downCast
            instance3.Print("Hello World");
            Console.ReadKey();
        }
    }
}


//Задание
//Используя Visual Studio, создайте проект по шаблону Console Application.
//Требуется:
//Создайте класс Printer.
//В теле класса создайте метод void Print(string value), который выводит на экран значение
//аргумента.
//Реализуйте возможность того, чтобы в случае наследования от данного класса других классов, и вызове
//соответствующего метода их экземпляра, строки, переданные в качестве аргументов методов,
//выводились разными цветами.
//Обязательно используйте приведение типов