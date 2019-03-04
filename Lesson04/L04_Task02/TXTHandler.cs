using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L04_Task02
{
    class TXTHandler : AbstractHandler
    {
        public override void Change()
        {
            Console.WriteLine("TXT - изменен");
        }

        public override void Create()
        {
            Console.WriteLine("TXT - создан");
        }

        public override void Open()
        {
            Console.WriteLine("TXT - открыт");
        }

        public override void Save()
        {
            Console.WriteLine("TXT - сохранен");
        }
    }
}
