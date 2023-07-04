using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Task1
{
    public class GoodPupil : Pupil
    {
        public override void Read()
        {
            Console.WriteLine("GoodPupil is Read");
        }

        public override void Write()
        {
            Console.WriteLine("GoodPupil is Write");
        }

        public override void Relax()
        {
            Console.WriteLine("GoodPupil is Relax");
        }

        public override void Study()
        {
            Console.WriteLine("GoodPupil is Study");
        }
    }
}
