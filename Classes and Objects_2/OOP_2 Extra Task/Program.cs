using System;

namespace OOP_2_Extra_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User newUser = new User(
               login: "Jasur99",
               name: "Jasur",
               lastName: "Sulaymonov",
               age: 28,
               date: DateTimeOffset.Now);

            Console.WriteLine(newUser);
            Console.ReadKey();
        }
    }
}
