using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L06_TaskAdd01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Сумма: {Calculator.Add(5, 6)}");
            Console.WriteLine($"Разница: {Calculator.Sub(5, 6)}");
            Console.WriteLine($"Произведение: {Calculator.Mul(5, 6)}");
            Console.WriteLine($"Деление: {Calculator.Div(15, 9)}");

            Console.ReadKey();
        }
    }
}
