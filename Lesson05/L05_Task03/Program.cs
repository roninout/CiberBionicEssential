using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L05_Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMatrix matrix = new MyMatrix(5, 10);

            Console.WriteLine(new string('*', 40));
            matrix.Show();
            Console.WriteLine(new string('*', 40));
            Console.WriteLine();

            Console.WriteLine(new string('*', 40));
            //Отображение элемента за инексами, с проверкой отрабатывания индексатора
            Console.WriteLine($"[1][2] = {matrix[1, 2]}"); 
            Console.WriteLine($"[6][2] = {matrix[13, 4]}"); // за пределом

            //Меняем значение элемента за инексами, с проверкой отрабатывания индексатора
            matrix[0, 0] = 44;
            matrix[10, 0] = 55; // за пределом
            Console.WriteLine(new string('*', 40));
            Console.WriteLine();

            // меняем размер матрицы
            Console.WriteLine(new string('*', 40));
            matrix.ChangeSize(6, 6); //Меняем размер матрицы
            matrix.Show(); //Отображения матрицы
            Console.WriteLine(new string('*', 40));
            Console.WriteLine();

            Console.WriteLine(new string('*', 40));
            matrix.Show(1, 0, 4, 4); //Вызов перегруженного метода отображения матрицы
            Console.WriteLine(new string('*', 40));
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
