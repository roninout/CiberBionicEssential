using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L06_TaskAdd01
{
    static class Calculator
    {
        public static double Add(double numb1, double numb2)
        {
            return numb1 + numb2;
        }

        public static double Sub(double numb1, double numb2)
        {
            return numb1 - numb2;
        }

        public static double Mul(double numb1, double numb2)
        {
            return numb1 * numb2;
        }

        public static double Div(double numb1, double numb2)
        {
            return (numb2 == 0) ? 0 : numb1 / numb2;
        }
    }
}
