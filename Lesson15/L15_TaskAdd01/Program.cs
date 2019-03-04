using System;
using System.Linq;

namespace L15_TaskAdd01
{
    class Program
    {
        static void Main(string[] args)
        {
            double? result = null;

            try
            {
                Console.Write("Введите 1-е число: ");
                double a = Double.Parse(Console.ReadLine());

                Console.Write("Введите 2-е число: ");
                double b = Double.Parse(Console.ReadLine());

                Console.Write("Введите операцию (+_*/): ");
                string op = Console.ReadLine();

                result = Calculator.Operation(a, b, op);
            }
            catch (Exception)
            {
                Console.WriteLine("Ввод данных оказадся не верным.");
                Console.WriteLine("Программа будет завершена!!!!!");
            }
            finally
            {
                if (result != null)
                    Console.WriteLine($"Результат: {result:##.#}");
                Console.ReadKey();
            }
        }
    }
}
