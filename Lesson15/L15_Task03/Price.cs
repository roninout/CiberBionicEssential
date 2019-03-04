using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L15_Task03
{
    struct Price
    {
        #region поля
        string productName;
        string shopName;
        double priceProduct;
        #endregion

        public Price(string productName, string shopName, double priceProduct)
        {
            this.productName = productName;
            this.shopName = shopName;
            this.priceProduct = priceProduct;
        }

        #region свойства
        public string ProductName { get => productName; }
        public string ShopName { get => shopName; }
        public double PriceProduct { get => priceProduct; }
        #endregion

        #region методы
        // метод выводит информацию о товаре
        public string Show()
        {
            return String.Format($"Товар: {ProductName}; Магазин: {ShopName}; Цена: {PriceProduct};");
        }
        #endregion
    }
}
