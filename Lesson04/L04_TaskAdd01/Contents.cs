using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L04_TaskAdd01
{
    class Contents : Element
    {
        public override string Content
        {
            get => String.IsNullOrEmpty(content) ? content : "Содержание отсутствует";
            set => content = value;
        }

        public override void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Содержание : {content}");
        }
    }
}
