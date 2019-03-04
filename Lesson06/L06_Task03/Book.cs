using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L06_Task02
{
    class Book
    {
        public void FindNext(string str)
        {
            FindAndReplaceManager.FindNext(str);
        }

        public class Note
        {
            private string text;

            public string Text
            {
                get => text;
                set => text += value + "\n";
            }
        }
    }
}
