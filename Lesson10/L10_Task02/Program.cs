using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L10_Task02
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

            Console.WriteLine(list[4]);
            Console.WriteLine();
            Console.WriteLine(new string('-', 30));

            MyList<string> list2 = new MyList<string>();
            list2.Add("a");
            list2.Add("b");
            list2.Add("c");

            for (int i = 0; i < list2.Count; i++)
                Console.WriteLine($"[{i}] - {list2[i]}");

            Console.WriteLine(list[4]);

            Console.ReadKey();
        }
    }
}
