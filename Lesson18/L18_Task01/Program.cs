using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using L14_Task03; // подключил внешнюю сборку

namespace L18_Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> dictionary = new MyDictionary<string, string>();
            dictionary.Add("apple", "яблоко");
            dictionary.Add("sun", "солнце");
            dictionary.Add("home", "дом");

            foreach (var item in dictionary)
                Console.WriteLine($"{item}");


            Console.WriteLine();
            Console.WriteLine(new string('-', 50));

            Console.WriteLine(dictionary["sun"]);
            Console.WriteLine(dictionary[2]);
            Console.WriteLine(dictionary[4]);

            Console.WriteLine(new string('-', 50));


            Console.ReadKey();
        }
    }
}
