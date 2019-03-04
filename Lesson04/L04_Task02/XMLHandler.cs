using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L04_Task02
{
    class XMLHandler : AbstractHandler
    {
        public override void Change()
        {
            Console.WriteLine("XML - изменен");
        }

        public override void Create()
        {
            Console.WriteLine("XML - создан");
        }

        public override void Open()
        {
            Console.WriteLine("XML - открыт");
        }

        public override void Save()
        {
            Console.WriteLine("XML - сохранен");
        }
    }
}
