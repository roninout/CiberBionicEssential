using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(0, 1, 1234, 120, 1980) { };
            Console.WriteLine($"Стоимость машины {car.Price}, скорость {car.Speed}, год выпуска {car.Year}");
            Console.WriteLine(new String('*', 65));

            Plane plane = new Plane(0, 1, 50000, 580, 2001) { Hight = 124, Passengers = 12 };
            Console.WriteLine($"Стоимость самолета {plane.Price}, скорость {plane.Speed}, год выпуска {plane.Year}, количество пасажиров {plane.Passengers}");
            Console.WriteLine(new String('*', 65));

            Ship ship = new Ship(0, 1, 650000, 25, 2015) { Destination = "", Passengers = 333 };
            Console.WriteLine($"Стоимость корабля {ship.Price}, скорость {ship.Speed}, год выпуска {ship.Year}, количество пасажиров {ship.Passengers}, место назначения {ship.Destination}");
            Console.WriteLine(new String('*', 65));

            Console.ReadKey();

        }
    }
}
