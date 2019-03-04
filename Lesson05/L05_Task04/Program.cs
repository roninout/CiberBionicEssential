using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L05_Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создали магазин и указали его размер
            Store store = new Store(4);

            // и наполняем его товарами
            store.AddArticleToStore(new Article("бананы", "Африка", 22.67), 0);
            store.AddArticleToStore(new Article("шелка", "Китай", 522.6), 1);
            store.AddArticleToStore(new Article("специи", "Индия", 123.1), 2);
            store.AddArticleToStore(new Article("макароны", "Италия", 89.2), 3);

            // Выборка по номеру
            Console.WriteLine(new String('*', 50));
            Console.WriteLine(store[2]);
            Console.WriteLine(new String('*', 50));
            Console.WriteLine();

            // Выборка по названию
            Console.WriteLine(new String('*', 50));
            Console.WriteLine(store["шелка"]);
            Console.WriteLine(new String('*', 50));
            Console.WriteLine();

            // Ошибочная выборка по номеру
            Console.WriteLine(new String('*', 50));
            Console.WriteLine(store[6]);
            Console.WriteLine(new String('*', 50));
            Console.WriteLine();

            // Ошибочная выборка по названию
            Console.WriteLine(new String('*', 50));
            Console.WriteLine(store["xaxa"]);
            Console.WriteLine(new String('*', 50));
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
