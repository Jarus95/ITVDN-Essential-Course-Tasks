using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extra_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Adress address = new Adress
            {
                Index = 0,
                Country = "Uzbekistan",
                City = "Tashkent",
                Street = "Center  Street",
                House = "12 House",
                Appartment = "22 Appartment"
            };

            Console.WriteLine(address);
            Console.ReadKey();
        }
    }
}
