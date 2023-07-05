using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Task1
{
    public class XMLHandler : AbstractHandler
    {
        public override void Chenge()
        {
            Console.WriteLine("change xml");
        }

        public override void Create()
        {
            Console.WriteLine("Create xml");
        }

        public override void Open()
        {
            Console.WriteLine("Open xml");
        }

        public override void Save()
        {
            Console.WriteLine("Save xml");
        }
    }
}
