using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L17_Task02
{
    class Car
    {
        public Car(string model, string brand, string color, int year)
        {
            Model = model;
            Brand = brand;
            Color = color;
            Year = year;
        }

        public string Brand { get; }
        public string Color { get; }
        public string Model { get; }
        public int Year { get; }
    }
}
