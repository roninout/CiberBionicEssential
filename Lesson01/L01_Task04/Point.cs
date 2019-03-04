using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L01_Task04
{
    class Point
    {
        private int x, y;
        private string str;

        public int X { get => x; }
        public int Y { get => y; }
        public string Str { get => str; }

        public Point(int x, int y, string str)
        {
            this.x = x;
            this.y = y;
            this.str = str;
        }

    }
}
