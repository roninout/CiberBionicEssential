using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L01_Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Стивен Кинг", "Черная башня", "Содержание");
            book.Show();
            Console.ReadKey();
        }
    }
}
