using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L11_Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            CarCollection<string> carCollection = new CarCollection<string>();

            carCollection.Add("Porshe", new DateTime(1966, 3, 11));
            carCollection.Add("Ferrary", new DateTime(1999, 4, 21));

            for (int i = 0; i < carCollection.Lenght; i++)
                Console.WriteLine(carCollection[i]);
            Console.WriteLine();

            Console.WriteLine(carCollection[5]);
            Console.WriteLine(carCollection["Porshe"]);
            Console.WriteLine(carCollection["Reno"]);

            Console.ReadKey();
        }
    }
}
