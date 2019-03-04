using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L15_Task03
{
    class Stock
    {
        SortedList<string, Price> product;
        string productName;
        string shopName;
        double priceProduct;

        public Stock()
        {
            this.product = new SortedList<string, Price>();
            InitIOData();
        }

        private void InitIOData(int size = 2)
        {
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(new string('*', 50));
                Console.Write("Введите название товара: ");
                productName = Console.ReadLine();

                Console.Write("Магазин: ");
                shopName = Console.ReadLine();

                try
                {
                    Console.Write("И его цену: ");
                    priceProduct = Double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Не правильный формат цены");
                    priceProduct = 0.0; // выставляем значение по умолчанию
                }

                try
                {
                    product.Add(productName, new Price(productName, shopName, priceProduct));
                }
                catch (Exception e) when (e is System.ArgumentException)
                {
                    Console.WriteLine("Введеный товар уже присутствует на складе");
                }
                catch (Exception)
                {
                    Console.WriteLine("Что-то произошло не так с вводом товара");
                }

            }
        }

        public void ShowAllProduct()
        {
            Console.WriteLine(new string('*', 50));
            foreach (var item in product)
                Console.WriteLine(item.Value.Show());
            Console.WriteLine(new string('*', 50));
        }

        public void SerchProduct(string name)
        {
            int count = 0;
            Console.WriteLine(new string('*', 50));
            foreach (var item in product)
            {
                if (item.Value.ShopName.Equals(name))
                {
                    Console.WriteLine(item.Value.Show());
                    count++;
                }
            }
            if (count < 1)
                Console.WriteLine("Товат отсутствует на складе!!!");
            Console.WriteLine(new string('*', 50));
        }
    }
}
