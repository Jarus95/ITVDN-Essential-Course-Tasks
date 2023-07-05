using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Task1
{
    public class Program
    {
        static void Main(string[] args)
        {
            AbstractHandler docHandler = new DOCHandler();
            docHandler.Chenge();
            docHandler.Create();
            docHandler.Open();
            docHandler.Open();
            Console.WriteLine(new string('-', 50));

            AbstractHandler txtHandler = new TXTHandler();
            txtHandler.Chenge();
            txtHandler.Create();
            txtHandler.Open();
            txtHandler.Open();
            Console.WriteLine(new string('-', 50));

            AbstractHandler xmlHandler = new XMLHandler();
            xmlHandler.Chenge();
            xmlHandler.Create();
            xmlHandler.Open();
            xmlHandler.Open();
            Console.WriteLine(new string('-', 50));

            Console.ReadKey();
        }
    }
}
