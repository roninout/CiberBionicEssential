using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L14_Task02
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

            //for (int i = 0; i < list.Count; i++)
            //    Console.WriteLine($"[{i}] - {list[i]}");

            int i = 0;
            foreach (var item in list)
            {
                Console.WriteLine($"[{i}] - {item}");
                i++;
            }

            Console.WriteLine(new string('-', 30));
            Console.WriteLine(list[4]);
            Console.WriteLine(new string('-', 30));

            Console.ReadKey();
        }
    }
}
