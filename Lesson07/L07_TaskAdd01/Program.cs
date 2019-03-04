using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L07_TaskAdd01
{
    class Program
    {
        static void Main(string[] args)
        {
            Notebook notebook = new Notebook("Apple", "China", 23467.7);
            notebook.Show();
            Console.ReadKey();
        }
    }
}
