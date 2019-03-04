using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L04_TaskAdd01
{
    class Book
    {
        Element title = null;
        Element author = null;
        Element contents = null;

        public Book()
        {
            title = new Title();
            author = new Author();
            contents = new Contents();
        }

        public void Show()
        {
            author.Show();
            title.Show();
            contents.Show();
        }

        // через свойства передаем значения
        public string Title { set => title.Content = value; }
        public string Author { set => author.Content = value; }
        public string Contents { set => contents.Content = value; }
    }
}
