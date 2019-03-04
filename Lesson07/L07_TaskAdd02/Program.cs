using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L07_TaskAdd02
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 32; i <= 127; i++)
                Console.WriteLine($"{i}-ый символ = {(char)i}");
            Console.ReadKey();
        }
    }
}
