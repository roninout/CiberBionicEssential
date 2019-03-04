using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L01_Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(3, 4);
            Console.WriteLine($"Площадь фигуры: {rectangle.Area}");
            Console.WriteLine($"Периметр фигуры: {rectangle.Perimeter}");

            Console.ReadKey();
        }
    }
}
