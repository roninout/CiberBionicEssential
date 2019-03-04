using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L10_Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> list = new MyList<int>();
            list.Add(23);
            list.Add(4);
            list.Add(78);
            list.Add(12);

            for (int i = 0; i < list.Count; i++)
                Console.WriteLine($"[{i}] - {list[i]}");

            Console.WriteLine(new string('-', 30));
            Console.WriteLine(list[4]);
            Console.WriteLine(new string('-', 30));

            int[] array = list.GetArray(); // Расширяющий метод
            for (int i = 0; i < array.Length; i++)
                Console.WriteLine($"[{i}] - {array[i]}");

            Console.ReadKey();
        }
    }
}