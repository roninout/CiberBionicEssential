using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L11_TaskAdd01
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add(22);
            list.Add(22.4);
            list.Add("xaxa");
            list.Add(new TestClaas(54));

            for (int i = 0; i < list.Count; i++)
                Console.WriteLine(list[i]);

            Console.ReadKey();
        }
        // Вопрос о проблеме не понятен????????????
        // PS. Наверное подразумевается Boxing - Unboxing
    }
}
