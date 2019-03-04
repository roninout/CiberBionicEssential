using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L04_TaskAdd01
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book()
            {
                Title = "Черная башня",
                Author = "Стивен Кинг",
                Contents = "Содержание"
            };
            book.Show();

            Console.ReadKey();
        }
    }
}
