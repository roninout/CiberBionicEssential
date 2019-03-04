﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L04_TaskAdd01
{
    class Author : Element
    {
        public override string Content
        {
            get => String.IsNullOrEmpty(content) ? content : "Нет автора";
            set => content = value;
        }

        public override void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Имя автора : {content}");
        }
    }
}
