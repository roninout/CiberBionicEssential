using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L08_Task02
{
    static class PrintColor
    {

        public static void Print(string stroka, int color)
        {
            switch (color)
            {
                case (int)RGBColors.red:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case (int)RGBColors.green:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case (int)RGBColors.blue:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                default:
                    Console.WriteLine("Цвет отсутствует в сиситеме");
                    break;
            }
            Console.WriteLine(stroka);
        }
    }
}
