using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L02_Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice(54, "Александр", "Амвей");
            invoice.Article = "дверь";
            invoice.Quantity = 2;

            Console.WriteLine(new String('*', 45));
            Console.WriteLine($"Информация о счете № - {invoice.account}");
            Console.WriteLine($"Клиент: {invoice.customer}");
            Console.WriteLine($"Поставщик: {invoice.provider}");
            invoice.Calculation(true);
            invoice.Calculation(false);
            Console.WriteLine(new String('*', 45));
            Console.ReadKey();
        }
    }
}
