﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L01_Task03
{
    class Title
    {
        readonly string title;

        public Title(string title)
        {
            this.title = title;
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Заглавие : {title}");
        }
    }
}
