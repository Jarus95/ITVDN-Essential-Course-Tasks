using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Extra_Task
{
    public class DerivedClass: Printer
    {
        public void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("DerivedClass:" + value);
        }
    }
}
