using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson03.Task02
{
    class Pupil
    {
        public virtual void Study()
        {
            Console.WriteLine("Pupil study");
        }

        public virtual void Read()
        {
            Console.WriteLine("Pupil read");
        }
        public virtual void Write()
        {
            Console.WriteLine("Pupil write");
        }
        public virtual void Relax()
        {
            Console.WriteLine("Pupil relax");
        }
    }
}
