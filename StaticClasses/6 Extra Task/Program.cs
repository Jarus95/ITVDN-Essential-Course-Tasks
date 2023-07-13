using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Extra_Task
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Calculator.Add(4, 3));
            Console.WriteLine(Calculator.Multiply(4, 3));
            Console.WriteLine(Calculator.Subtract(4, 3));
            Console.WriteLine(Calculator.Divide(4, 3));
            Console.ReadKey();
        }
    }
}

//Используя Visual Studio, создайте проект по шаблону Console Application.
//Требуется:
//Создать статический класс Calculator, с методами для выполнения основных арифметических
//операций.
//Написать программу, которая выводит на экран основные арифметические операции
