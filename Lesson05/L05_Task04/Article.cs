using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L05_Task04
{
    class Article
    {
        private double price;

        // Пользовательский конструктор
        public Article(string name, string nameShop, double price)
        {
            Name = name;
            NameShop = nameShop;
            Price = price;
        }

        // Свойства и автосвойства
        public string Name { set; get; }
        public string NameShop { set; get; }
        public double Price
        {
            set
            {
                if (value >= 0)
                    price = value;
                else
                    Console.WriteLine("Стоимости товара было присвоно отрицательное значение!");
            }
            get { return price; }
        }

        // Отображаем информацию о товаре
        public string Show()
        {
            return string.Format($"Товар {Name} из магазина {NameShop} стоимостью - {Price}");
        }
    }
}
