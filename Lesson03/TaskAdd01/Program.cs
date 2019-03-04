using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskAdd01
{
    class Program
    {
        static void Main(string[] args)
        {
            NewPrinter printer = new NewPrinter(ConsoleColor.Green);
            printer.Print("Тук");

            Printer printUpCast = printer as NewPrinter;
            printUpCast.Print("Base");

            NewPrinter pr = new NewPrinter(ConsoleColor.DarkMagenta);
            pr.Print("ха-ха");

            Console.ReadKey();
        }
    }
}
