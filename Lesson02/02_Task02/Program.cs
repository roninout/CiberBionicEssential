using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L02_Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            Converter converter = new Converter(26.125, 30.375, 0.335);

            converter.UsdToUah(100.0);
            converter.UahToUsd(100.0);
            Console.WriteLine();

            converter.EurToUah(100.0);
            converter.UahToEur(100.0);
            Console.WriteLine();

            converter.RubToUah(100.0);
            converter.UahToRub(100.0);
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
