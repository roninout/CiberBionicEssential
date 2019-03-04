using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    class Ship : Vehicle
    {
        int passengers;
        public int Passengers
        {
            get
            {
                return passengers;
            }
            set
            {
                if (passengers < 0)
                    Console.WriteLine("Пассажиры только положительные )");
                else
                    passengers = value;
            }
        }

        string destination;
        public string Destination {
            get
            {
                if (String.IsNullOrEmpty(destination))
                    destination = "Место назаначения не указано";
                return destination;
            }
            set
            {
                if (destination == value)
                {
                    return;
                }

                destination = value;
            }
        }

        public Ship(int x, int y, int price, int speed, int year)
            : base(x, y, price, speed, year)
        {

        }
    }
}
