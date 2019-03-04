using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L01_Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            new Figure(new Point(1,1,"A"), new Point(2, 2, "B"), new Point(3, 3, "C")).PerimeterCalculator(); ;

            new Figure(new Point(1, 1, "A"), new Point(2, 2, "B"), new Point(3, 3, "C"), new Point(4, 4, "D")).PerimeterCalculator();

            Console.ReadKey();
        }
    }
}
