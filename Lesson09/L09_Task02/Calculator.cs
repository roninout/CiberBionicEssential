using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L09_Task02
{
    class Calculator
    {
        // словарь с предустановленными операциями
        private Dictionary<string, Func<double, double, double>> dictionary = new Dictionary<string, Func<double, double, double>>
        {
            {"+", (x, y) => x + y},
            //{"-", (x, y) => x - y},
            {"*", (x, y) => x * y},
            {"/", delegate(double x, double y)
            {
                if (y != 0)
                    return x / y;
                else
                {
                    Console.WriteLine("Деление на ноль!");
                    return 0;
                }
            }},
        };

        // метод выполняет операцию по ключу из словаря
        public double Operation(string op, double x, double y)
        {
            if (!dictionary.ContainsKey(op))
            {
                Console.WriteLine("Данное действие недоступно!!!");
                return 0;
            }
            return dictionary[op].Invoke(x, y);
        }

        // метод добавления нового действия в словарь
        public void NewOperation(string op, Func<double, double, double> func)
        {
            if (dictionary.ContainsKey(op))
                Console.WriteLine("Операция уже существует!!!");
            else
                dictionary.Add(op, func);
        }
    }
}
