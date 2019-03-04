using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson03.Task02
{
    class ExcelentPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Excelent pupil study");
        }

        public override void Read()
        {
            Console.WriteLine("Excelent pupil read");
        }
        public override void Write()
        {
            Console.WriteLine("Excelent pupil write");
        }
        public override void Relax()
        {
            Console.WriteLine("Excelent pupil relax");
        }
    }
}
