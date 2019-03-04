using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L02_Task02
{
    class Converter
    {
        public double usd;
        public double eur;
        public double rub;

        public Converter(double usd, double eur, double rub)
        {
            this.usd = usd;
            this.eur = eur;
            this.rub = rub;
        }

        public void UsdToUah(double quantity)
        {
            Console.WriteLine("{0} USD - {1} UAH", quantity, quantity * usd);
        }

        public void UahToUsd(double quantity)
        {
            Console.WriteLine("{0} UAH - {1:#.##} USD", quantity, quantity / usd);
        }

        public void EurToUah(double quantity)
        {
            Console.WriteLine("{0} EUR - {1} UAH", quantity, quantity * eur);
        }

        public void UahToEur(double quantity)
        {
            Console.WriteLine("{0} UAH - {1:#.##} EUR", quantity, quantity / eur);
        }

        public void RubToUah(double quantity)
        {
            Console.WriteLine("{0} RUB - {1} UAH", quantity, quantity * rub);
        }

        public void UahToRub(double quantity)
        {
            Console.WriteLine("{0} UAH - {1:#.##} RUB", quantity, quantity / rub);
        }
    }
}
