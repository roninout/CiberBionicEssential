using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L17_TaskAdd01
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic result = null;

            try
            {
                Console.Write("Введите 1-е число: ");
                dynamic a = Double.Parse(Console.ReadLine());

                Console.Write("Введите 2-е число: ");
                dynamic b = Double.Parse(Console.ReadLine());

                Console.Write("Введите операцию (+_*/): ");
                dynamic op = Console.ReadLine();

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
