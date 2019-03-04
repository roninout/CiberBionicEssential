using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace L13_Task01
{
    class Field
    {
        public int Width { get; set; }      // ширина консоли
        public int Lenght { get; set; }     // высота консоли

        // пользовательский конструктор
        public Field(int width, int lenght)
        {
            Width = width;
            Lenght = lenght;
            Console.SetWindowSize(width, lenght);
            Console.Title = "The Matrix";
        }

        // запускаем матрицу
        public void RunMatrix()
        {
            for (int i = 2; i < Width; i++)
                new Thread(new DropTear().Fall).Start();
        }
    }
}
