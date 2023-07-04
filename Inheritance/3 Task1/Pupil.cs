using System;
using System.Xml;

namespace _3_Task1
{
    public class Pupil
    {
        public virtual void Study()
        {
            Console.WriteLine("Study");
        }
        public virtual void Read()
        {
            Console.WriteLine("Read");
        }
        public virtual void Write()
        {
            Console.WriteLine("Write");
        }
        public virtual void Relax()
        {
            Console.WriteLine("Relax");
        }
    }
}
