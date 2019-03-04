using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L09_TaskAdd01
{
    class Program
    {
        private delegate double Mydelegate(int param1, int param2, int param3);

        static void Main(string[] args)
        {
            Console.Write("1-е число: ");
            int.TryParse(Console.ReadLine(), out int a);

            Console.Write("2-е число: ");
            int.TryParse(Console.ReadLine(), out int b);

            Console.Write("3-е число: ");
            int.TryParse(Console.ReadLine(), out int c);

            Mydelegate mydelegate = (param1, param2, param3) => (param1 + param2 + param3) / 3.0;
            Console.WriteLine($"Результат: {mydelegate(a,b,c) : ##.##}");

            Console.ReadKey();
        }
    }
}
