using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L04_TaskAdd01
{
    abstract class Element
    {
        protected string content;
        abstract public string Content { get; set; }
        abstract public void Show();
    }
}
