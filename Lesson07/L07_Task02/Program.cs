using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L07_Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            Schedule schedule = new Schedule(3);

            schedule.AddTrainsToSchedule();

            schedule.Show();

            Console.ReadKey();
        }
    }
}
