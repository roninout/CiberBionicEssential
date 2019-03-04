using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L10_Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> dictionary = new MyDictionary<string, string>();
            dictionary.Add("apple", "яблоко");
            dictionary.Add("sun", "солнце");
            dictionary.Add("home","дом");

            for (int i = 0; i < dictionary.Lenght; i++)
                Console.WriteLine($"{dictionary[i]}");

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
