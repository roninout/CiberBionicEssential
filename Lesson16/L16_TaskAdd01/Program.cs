using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L16_TaskAdd01
{
    class Program
    {
        static void Main(string[] args)
        {
            Point point1= new Point(1, 2, 3);
            Point point2 = new Point(-2, 1, -3);
            Point pointResult = point1 + point2;

            Console.WriteLine($"Результат сложения точек: { pointResult.X} { pointResult.Y} { pointResult.Z}");

            Console.ReadKey();
        }
    }
}
