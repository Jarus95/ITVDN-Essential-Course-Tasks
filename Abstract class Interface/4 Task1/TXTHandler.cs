using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Task1
{
    public class TXTHandler : AbstractHandler
    {
        public override void Chenge()
        {
            Console.WriteLine("change txt");
        }

        public override void Create()
        {
            Console.WriteLine("Create txt");
        }

        public override void Open()
        {
            Console.WriteLine("Open txt");
        }

        public override void Save()
        {
            Console.WriteLine("Save txt");
        }
    }
}
