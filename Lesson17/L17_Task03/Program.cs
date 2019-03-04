using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L17_Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            var dictionary = new Dictionary<dynamic, dynamic>
            {
                //{ new {Key =  "apple" }, new {Value =  "яблоко"}},
                { new {Key =  "sun"}, new {Value =  "солнце"}},
                { new {Key =  "home"}, new {Value =  "дом"}}
            };
            dictionary.Add(new { Key = "apple" }, new { Value = "яблоко" });

            foreach (var item in dictionary)
                Console.WriteLine($"{item.Key} - {item.Value}");
            Console.ReadKey();
        }
    }
}
