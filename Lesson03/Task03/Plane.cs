﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    class Plane : Vehicle
    {
        public int Hight { get; set; }
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

        public Plane(int x, int y, int price, int speed, int year)
            : base(x, y, price, speed, year)
        {

        }
    }
}
