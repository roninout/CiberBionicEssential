using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L08_Task03
{
    class Program
    {
        static void Main()
        {
            Post worker = Post.PRESIDENT;

            string str = new Accauntant().AscForBonus(worker, 95) ? "He receives bonuses. He was working more than " : "He doesn't receive bonuses. He was working less than";
            Console.WriteLine($"Employee has a Post: {worker}. {str} {(int)worker} hours.");
            Console.ReadKey();
        }
    }
}
