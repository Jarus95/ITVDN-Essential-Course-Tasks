using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Task2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Ship ship = new Ship(500, 200, 1999)
            {
                NumberOfPessengers = 1,
                Port = 4
            };
            Console.ReadKey();
        }
    }
}
//Используя Visual Studio, создайте проект по шаблону Console Application.
//Требуется:
//Создать класс Vehicle.
//В теле класса создайте поля: координаты и параметры средств передвижения (цена, скорость, год
//выпуска).
//Создайте 3 производных класса Plane, Саг и Ship.
//Для класса Plane должна быть определена высота и количество пассажиров.
//Для класса Ship — количество пассажиров и порт приписки.
//Написать программу, которая выводит на экран информацию о каждом средстве передвижения