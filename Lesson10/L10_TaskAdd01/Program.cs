using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L10_TaskAdd01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MyClass<int>.FacrotyMethod().GetType());
            Console.WriteLine(MyClass<double>.FacrotyMethod().GetType());
            // Использовать ограничение new можно только в том случае, если тип не является абстрактным.
            //Console.WriteLine(MyClass<string>.FacrotyMethod().GetType()); // string извини (


            Console.ReadKey();
        }
    }
}
