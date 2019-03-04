using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L04_Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractHandler handler = null;

            Console.WriteLine("Введите формат файла");
            string type = Console.ReadLine().ToLower();

            switch (type)
            {
                case "xml":
                    handler = new XMLHandler();
                    break;
                case "txt":
                    handler = new TXTHandler();
                    break;
                case "doc":
                    handler = new DOCHandler();
                    break;
                default:
                    Console.WriteLine("Формат не определен");
                    Console.ReadKey();
                    return;
            }

            handler.Change();
            handler.Create();
            handler.Open();
            handler.Save();

            Console.ReadKey();
        }
    }
}
