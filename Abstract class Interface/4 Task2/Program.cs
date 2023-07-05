using System;

namespace _4_Task2
{
    
    public class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            player.Play();
            player.Record();
            Console.WriteLine(new string('-', 50));
            IRecodable recodable = player as IRecodable;
            recodable.Pause();
            recodable.Stop();
            Console.WriteLine(new string('-', 50));
            IPlayable playable = player as IPlayable;
            playable.Pause();
            playable.Stop();

            Console.ReadKey();
        }
    }
}


//Используя Visual Studio, создайте проект по шаблону Console Application.
//Требуется:
//Создайте 2 интерфейса IPlayable и IRecodable. В каждом из интерфейсов создайте по 3 метода void
//Play() / void Pause() / void Stop() и void Record() / void Pause() / void Stop() соответственно.
//Создайте производный класс Player от базовых интерфейсов IPlayable и IRecodable.
//Написать программу, которая выполняет проигрывание и запись.