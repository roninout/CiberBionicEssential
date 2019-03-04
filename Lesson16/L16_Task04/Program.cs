using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L16_Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            string result;
            Console.WriteLine(new string('*', 50));
            OverData date1 = new OverData(DateTime.Now);
            Console.WriteLine($"1-я дата: {date1.ToString()}");

            OverData date2 = new OverData(new DateTime(2018, 08, 10));
            Console.WriteLine($"2-я дата: {date2.ToString()}");
            Console.WriteLine(new string('*', 50));

            Console.WriteLine();
            Console.WriteLine(new string('*', 80));
            result = OverData.Add(date1, date2).ToString();
            Console.Write($"Количество {OverData.countDays} дней между датами + к первой дате: {result}");
            Console.WriteLine();
            result = OverData.Sub(date1, date2).ToString();
            Console.Write($"Количество {OverData.countDays} дней между датами - от первой даты: {result}");
            Console.WriteLine();
            Console.WriteLine(new string('*', 80));

            // Delay.
            Console.ReadKey();
        }
    }
}
