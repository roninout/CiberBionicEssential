using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L01_TaskAdd01
{
    class Program
    {
        static void Main(string[] args)
        {
            Adress adress = new Adress()
            {
                Index = "256256",
                Country = "Украина",
                City = "Киев",
                Street = "Энтузиастов",
                House = "54",
                Apartment = "25"
            };

            Console.WriteLine(new String('*', 30));
            Console.WriteLine($"Индекс  : {adress.Index}");
            Console.WriteLine($"Страна  : {adress.Country}");
            Console.WriteLine($"Город   : {adress.City}");
            Console.WriteLine($"Улица   : {adress.Street}");
            Console.WriteLine($"Дом     : {adress.House}");
            Console.WriteLine($"Квартира: {adress.Apartment}");
            Console.WriteLine(new String('*', 30));

            Console.ReadKey();
        }
    }
}
