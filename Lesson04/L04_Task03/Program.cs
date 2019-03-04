using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L04_Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();

            IRecodable recodable = player as Player;
            player.Record();
            recodable.Stop();
            recodable.Pause();

            Console.WriteLine();

            player.Play();
            (player as IPlayable).Stop();
            (player as IPlayable).Pause();

            Console.ReadKey();
        }
    }
}
