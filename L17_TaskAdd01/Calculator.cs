using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L17_TaskAdd01
{
    static class Calculator
    {
        #region  методы арифметических операций
        // сложение
        private static dynamic Add(dynamic a, dynamic b)
        {
            return a + b;
        }

        // вычитание
        private static dynamic Sub(dynamic a, dynamic b)
        {
            return a - b;
        }

        // умножение
        private static dynamic Mul(dynamic a, dynamic b)
        {
            return a * b;
        }

        // деление
        // необходимо что-то вернуть. 0 - не подходит. Возвращаем в случае ошибки null
        // null полезен тем, что на него можно сделать проверку
        private static dynamic Div(dynamic a, dynamic b)
        {
            return (b != 0) ? a / b : "Деление на 0";
        }

        #endregion

        public static dynamic Operation(dynamic a, dynamic b, dynamic op)
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
