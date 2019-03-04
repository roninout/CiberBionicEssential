using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L07_TaskAdd01
{
    struct Notebook
    {
        public string Model { get; }
        public string Manufacturer { get; }
        public double Price { get; }

        public Notebook(string model, string manufacturer, double price)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
        }

        public void Show()
        {
            Console.WriteLine($"Модель ноутбука: {Model}");
            Console.WriteLine($"Производитель: {Manufacturer}");
            Console.WriteLine($"Стоимость: {Price} $");
        }
    }
}
