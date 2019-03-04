using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L06_Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            book.FindNext("слово");

            Book.Note note = new Book.Note();

            note.Text = "Первая заметка";
            note.Text = "Вторая заметка";

            Console.WriteLine(note.Text);

            Console.ReadKey();
        }
    }
}
