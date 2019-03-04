using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L08_Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");
            string line = Console.ReadLine();
            Console.WriteLine("Введите c клавиатуоа номер одного из RGB цветов (0-2):");
            int color = 0;
            int.TryParse(Console.ReadLine(), out color);

            PrintColor.Print(line, color);
            Console.ReadKey();

        }
    }
}
