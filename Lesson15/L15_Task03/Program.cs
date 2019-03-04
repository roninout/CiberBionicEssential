using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L15_Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            Stock stock = new Stock();
            stock.ShowAllProduct();

            Console.WriteLine("Введите название магазина:");
            string shop = Console.ReadLine();

            stock.SerchProduct(shop);

            Console.ReadKey();
        }
    }
}
