using System;
using System.Collections;
using System.Linq;

namespace L14_TaskAdd01
{
    class Program
    {

        // метод поиска четных значений
        static IEnumerable EvenNumbers(int[] arr)
        {
            // проверка на длину массива
            if (arr.Length == 0)
                yield break;

            foreach (int arrItem in arr)
            {
                if (arrItem % 2 == 0)
                    yield return arrItem;
            }

        }
        static void Main(string[] args)
        {
            int[] numbers = new int[20];

            // инициализация массива значениями
            for (int i = 0; i < numbers.Length; i++)
                numbers[i] = i;

            IEnumerable enumerable = EvenNumbers(numbers);
            foreach (var item in enumerable)
                Console.WriteLine($"[{item}]");

            Console.ReadKey();
        }
    }


}
