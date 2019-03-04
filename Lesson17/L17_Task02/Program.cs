using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L17_Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            var cars = new List<Car>
            {
                new Car("C4","Citroen","grey", 2009),
                new Car("Brabus","Mersedes","red", 2010),
                new Car("X5","BMW","black", 2011),
                new Car("A3","Audi","green", 2012)
            };

            var clients = new List<Client>
            {
                new Client("Alexander","C4","025-154-22-33"),
                new Client("Vlad","Brabus","035-154-22-33"),
                new Client("Anna","X5","045-154-22-33"),
                new Client("Oleg","A3","055-154-22-33")
            };

            var query = from client in clients
                        join car in cars on client.Model equals car.Model
                        select new
                        {
                            Name = client.Name,
                            Phone = client.Phone,
                            Model = client.Model,
                            Brand = car.Brand,
                            Color = car.Color,
                            Year = car.Year
                        };

            foreach (var item in query)
            {
                Console.WriteLine(new string('*', 50));
                Console.WriteLine($"Client info: {item.Name} - {item.Phone}");
                Console.WriteLine($"Car info:    {item.Brand} - {item.Model} - {item.Color} - {item.Year}");
            }
            Console.WriteLine(new string('*', 50));
            Console.ReadKey();

        }
    }
}
