using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Task1
{
    public class BadPupil : Pupil
    {
        public override void Read()
        {
            Console.WriteLine("BadPupil is Read");
        }

        public override void Write()
        {
            Console.WriteLine("BadPupil is Write");
        }

        public override void Relax()
        {
            Console.WriteLine("BadPupil is Relax");
        }

        public override void Study()
        {
            Console.WriteLine("BadPupil is Study");
        }
    }
}
