using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskAdd01
{
    class Printer
    {
        // необходимо сбросить цвет
        protected readonly ConsoleColor color = ConsoleColor.White;

        public Printer(ConsoleColor color)
        {
            this.color = color;
        }

        public virtual void Print(string value)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(value);
        }
    }
}
