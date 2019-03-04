using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L12_Task03
{
    class Model
    {
        public Model()
        {
            Minutes = 0;
            Seconds = 0;
            Millis = 0;
        }

        public int Minutes { get; set; }
        public int Seconds { get; set; }
        public int Millis { get; set; }
        public int Ticks { get; set; }

        public bool IsEnabled { get; set; }



        public void Calculate()
        {
            Millis++;
            if (Millis > 9)
            {
                Millis = 0;
                Seconds++;

                if (Seconds > 59)
                {
                    Seconds = 0;
                    Minutes++;
                }
            }

        }
    }
}
