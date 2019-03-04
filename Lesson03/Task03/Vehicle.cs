using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    class Vehicle
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Price { get; set; }
        public int Speed { get; set; }
        public int Year { get; set; }

        public Vehicle(int x, int y, int price, int speed, int year)
        {
            this.X = x;
            this.Y = y;
            this.Price = price;
            this.Speed = speed;
            this.Year = year;
        }
    }
}
