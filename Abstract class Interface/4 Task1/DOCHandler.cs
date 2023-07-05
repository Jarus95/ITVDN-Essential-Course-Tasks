using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Task1
{
    internal class DOCHandler : AbstractHandler
    {
        public override void Chenge()
        {
            Console.WriteLine("change doc");
        }

        public override void Create()
        {
            Console.WriteLine("Create doc");
        }

        public override void Open()
        {
            Console.WriteLine("Open doc");
        }

        public override void Save()
        {
            Console.WriteLine("Save doc");
        }
    }
}
