using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using L11_TaskAdd01;

namespace L11_Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList array = new ArrayList();

            array.Add("xaxa");
            array.Add(55);
            array.Add(45.7);
            array.Add(new TestClaas(45));

            for (int i = 0; i < array.Count; i++)
                Console.WriteLine(array[i]);

            Console.WriteLine(new String('*', 50));
            Console.WriteLine("Удаляем все значения массива");
            array.Clear();
            Console.WriteLine(new String('*', 50));

            Console.WriteLine("Проверка");
            for (int i = 0; i < array.Count; i++)
                Console.WriteLine(array[i]);

            Console.ReadKey();
        }
    }
}
