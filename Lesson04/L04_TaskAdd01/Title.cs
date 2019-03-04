using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L04_TaskAdd01
{
    class Title : Element
    {
        public override string Content
        {
            get => String.IsNullOrEmpty(content) ? content : "Заглавие отсутствует";
            set => content = value;
        }

        public override void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Заглавие : {content}");
        }
    }
}
