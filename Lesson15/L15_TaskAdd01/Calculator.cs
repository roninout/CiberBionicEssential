using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L15_TaskAdd01
{
    static class Calculator
    {
        #region  методы арифметических операций
        // сложение
        private static double Add(double a, double b)
        {
            return a + b;
        }

        // вычитание
        private static double Sub(double a, double b)
        {
            return a - b;
        }

        // умножение
        private static double Mul(double a, double b)
        {
            return a * b;
        }

        // деление
        // необходимо что-то вернуть. 0 - не подходит. Возвращаем в случае ошибки null
        // null полезен тем, что на него можно сделать проверку
        private static double? Div(double a, double b)
        {
            try
            {
                return a / b;
            }
            catch (Exception)
            {
                Console.WriteLine("Деление на 0");
                return null;
            }
        }

        #endregion

        public static double? Operation(double a, double b, string op)
        {
            switch (op)
            {
                case "+":
                    return Add(a, b);
                case "-":
                    return Sub(a, b);
                case "*":
                    return Mul(a, b);
                case "/":
                    return Div(a, b);
                default:
                    Console.WriteLine("Операция не определена");
                    return null;
            }
        }
    }
}
