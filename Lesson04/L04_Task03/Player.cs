using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L04_Task03
{
    class Player : IPlayable, IRecodable
    {
        public void Play()
        {
            Console.WriteLine("Play");
        }
        void IPlayable.Pause()
        {
            Console.WriteLine("Play/Pause");
        }

        void IPlayable.Stop()
        {
            Console.WriteLine("Play/Stop");
        }

        public void Record()
        {
            Console.WriteLine("Record");
        }

        void IRecodable.Pause()
        {
            Console.WriteLine("Record/Pause");
        }

        void IRecodable.Stop()
        {
            Console.WriteLine("Record/Stop");
        }
    }
}
