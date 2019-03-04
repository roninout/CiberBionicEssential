using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L16_Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            Block block1 = new Block(1, 2, 3, 4);
            //Block block1 = new Block(5, 6, 7, 8);
            Block block2 = new Block(5, 6, 7, 8);

            Console.WriteLine(new string('*', 50));
            Console.Write($"Сравниваем блоки через Equals: {block1.Equals(block2)}");
            Console.WriteLine();

            Console.WriteLine(new string('*', 50));
            Console.Write($"Сравниваем блоки через GetHashCode: {block1.GetHashCode() == block2.GetHashCode()}");
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
