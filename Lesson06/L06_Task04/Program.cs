using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L06_Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 2, 1, -54, 0, 86, -4 };

            Console.WriteLine("До сортировки");
            for (int i = 0; i < array.Length; i++)
                Console.WriteLine($"[{i}] - [{array[i]}]");

            array.SortByBuble();

            Console.WriteLine("\nПосле сортировки");
            for (int i = 0; i < array.Length; i++)
                Console.WriteLine($"[{i}] - [{array[i]}]");

            Console.ReadKey();
        }
    }
}
