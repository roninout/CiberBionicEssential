using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L07_Task02
{
    struct Train
    {
        public Train(string destination, int trainNumber, DateTime departureTime)
        {
            Destination = destination;
            TrainNumber = trainNumber;
            DepartureTime = departureTime;
        }

        public string Destination { get; }
        public int TrainNumber { get; }
        public DateTime DepartureTime { get; }

    }
}
