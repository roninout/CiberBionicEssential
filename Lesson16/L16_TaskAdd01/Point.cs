using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L16_TaskAdd01
{
    struct Point
    {
        // конструктор
        public Point(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        // автосвойства
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        // перегружаем оператор сложения
        public static Point operator +(Point point1, Point point2)
        {
            return new Point(point1.X + point2.X, point1.Y + point2.Y, point1.Z + point2.Z);
        }
    }
}
