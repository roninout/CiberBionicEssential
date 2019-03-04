using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L09_Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            Console.WriteLine(new String('*', 30));
            Console.WriteLine("Сумма: {0}", calculator.Operation("+", 10.5, 5.5));
            Console.WriteLine(new String('*', 30));
            Console.WriteLine("Деление: {0}", calculator.Operation("/", 10.5, 12.5));
            Console.WriteLine(new String('*', 30));

            // добавляем новую опервцию в словарь
            calculator.NewOperation("-", (x, y) => x - y);
            // проверяем
            Console.WriteLine("Вычитание: {0}", calculator.Operation("-", 10.5, 5.5));
            Console.WriteLine(new String('*', 30));
            // проверяем на несуществующую операцию
            Console.WriteLine("Модуль: {0}", calculator.Operation("%", 10.5, 5.5));
            Console.WriteLine(new String('*', 30));

            // проверяем на существующую операцию
            calculator.NewOperation("+", (x, y) => x + y);
            Console.WriteLine(new String('*', 30));

            Console.ReadKey();
        }
    }
}
