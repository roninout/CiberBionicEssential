using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson03.Task02
{
    class GoodPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Good pupil study");
        }

        public override void Read()
        {
            Console.WriteLine("Good pupil read");
        }
        public override void Write()
        {
            Console.WriteLine("Good pupil write");
        }
        public override void Relax()
        {
            Console.WriteLine("Good pupil relax");
        }
    }
}
