using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L02_Task04
{
    class Invoice
    {
        public readonly int account;
        public readonly string customer;
        public readonly string provider;

        public string Article { get; set; }
        public int Quantity { get; set; }

        public Invoice(int account, string customer, string provider)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
        }

        public void Calculation(bool nds)
        {
            double money = 0;
            switch (Article)
            {
                case "дверь":
                    money = 154;
                    break;
                case "стуло":
                    money = 54;
                    break;
                default:
                    Console.WriteLine("Нет такого товара");
                    return; // выходим из-за отсутсвтия артикля
            }

            money = money * Quantity;

            if (nds)
                Console.WriteLine("Изделие {0} в количестве {1} шт на сумму {2} c НДС {3}", Article, Quantity, money, money * 0.2 + money);
            else
                Console.WriteLine("Изделие {0}в количестве {1} шт на сумму {2}", Article, Quantity, money);
        }
    }
}
