using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson03.Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassRoom classRoom = new ClassRoom(new Pupil(), new ExcelentPupil());
            classRoom.Study();
            Console.WriteLine();
            classRoom.Write();
            Console.WriteLine();
            classRoom.Read();
            Console.WriteLine();
            classRoom.Realax();
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
