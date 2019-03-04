using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L04_Task02
{
    class DOCHandler : AbstractHandler
    {
        public override void Change()
        {
            Console.WriteLine("DOC - изменен");
        }

        public override void Create()
        {
            Console.WriteLine("DOC - создан");
        }

        public override void Open()
        {
            Console.WriteLine("DOC - открыт");
        }

        public override void Save()
        {
            Console.WriteLine("DOC - сохранен");
        }
    }
}
