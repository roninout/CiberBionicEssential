using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L05_Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = 0;
            int max = 0;
            int sum = 0;

            Console.WriteLine("Введите размерность массива");
            int count = 0;
            Int32.TryParse(Console.ReadLine(), out count);

            // проверяем на положительную размерность
            int[] array = new int[Math.Abs(count)];
            // сгенерируем случайный набор чисел
            Random random = new Random();
            // заполняем массив числами от -256 до 256
            for (int i = 0; i < array.Length; i++)
                array[i] = random.Next(-256, 256);

            min = max = array[0];
            foreach (int arrayItem in array)
            {
                if (arrayItem > max)
                    max = arrayItem;
                if (arrayItem < min)
                    min = arrayItem;
                sum += arrayItem;
            }

            Console.WriteLine("Выводим массив");
            for (int i = 0; i < array.Length; i++)
                Console.WriteLine($"[{i}] - [{array[i]}]");

            Console.WriteLine($"Максимальный элемент массива: {max}");
            Console.WriteLine($"Минимальный элемент массива: {min}");
            Console.WriteLine($"Сумма: {sum}");
            Console.WriteLine($"Среднее арифметическое: {(double)sum/array.Length: #.##}");

            Console.WriteLine("Выводим нечетные элементы массива");
            foreach (int arrayItem in array)
            {
                if (arrayItem % 2 != 0)
                    Console.WriteLine($"[{arrayItem}]");
            }

            Console.ReadKey();
        }
    }
}
