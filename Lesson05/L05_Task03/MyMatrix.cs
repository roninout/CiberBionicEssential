using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L05_Task03
{
    class MyMatrix
    {
        private int[][] matrix;
        private Random rand = new Random(); // будем генерить

        // Пользовательский конструктор
        public MyMatrix(int row, int col)
        {
            // переводим в позитив )
            row = Math.Abs(row);
            col = Math.Abs(col);

            // создаем
            matrix = new int[row][];
            for (int i = 0; i < row; i++)
                matrix[i] = new int[col];

            // Заполняемрандомными значениями
            InitMatrix();
        }

        // Заполняем матрицу рандомными значениями
        void InitMatrix() 
        {
            for (int i = 0; i < matrix.Length; i++)
                for (int j = 0; j < matrix[i].Length; j++)
                    matrix[i][j] = rand.Next(10, 99);
        }

        // Отображаем матрицу
        public void Show()
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                    Console.Write($"{matrix[i][j]}  ");
                Console.WriteLine();
            }
        }

        // Отображаем матрицу - перегружаем для частичного отображения матрицы
        public void Show(int startRow, int startCol, int endRow, int endCol)
        {
            for (int i = startRow; i < endRow; i++)
            {
                for (int j = startCol; j < endCol; j++)
                    Console.Write($"{matrix[i][j]}  ");
                Console.WriteLine();
            }
        }

        //Индексатор для матрицы
        public int this[int index1, int index2]
        {
            get 
            {
                if (index1 >= 0 && index1 < matrix.Length && index2 >= 0 && index2 < matrix[0].Length)
                    return matrix[index1][index2];
                Console.WriteLine("Индекс считывания за пределами массива");
                return 0;
            }

            set 
            {
                if (index1 >= 0 && index1 < matrix.Length && index2 >= 0 && index2 < matrix[0].Length)
                    matrix[index1][index2] = value;
                else
                    Console.WriteLine("Индекс записи за пределами массива");
            }
        }

        // Меняем размер матрицы - подсмотрел (
        public void ChangeSize(int row, int col)
        {
            if (row <= 0 || col <= 0)
            {
                Console.WriteLine("Размеры матрици не могут быть меньшими или равными нулю");
                return;
            }

            var matrixNew = new int[row][]; //Создание неявно типизированного зубчатого массива с указанием количества строк

            for (int i = 0; i < row; i++)
                matrixNew[i] = new int[col]; //Создание массивов в качестве каждого элемента зубчатого массива

            for (int i = 0; i < Math.Min(matrix.Length, row); i++) //Изменение числа строк
            {
                for (int j = 0; j < Math.Min(matrix[i].Length, col); j++) //Изменение числа столбцов
                    matrixNew[i][j] = matrix[i][j];
            }

            if (row > matrix.Length) //Если количество строк массива matrix меньше значения переменной row
            {
                for (int i = matrix.Length; i < row; i++)
                    for (int j = 0; j < Math.Min(col, matrix[0].Length); j++)
                        matrixNew[i][j] = rand.Next(10, 90); //то заполняем пустые строки нового массива рандомными значениями
            }

            if (col > matrix[0].Length) //Если количество столбцов массива matrix меньше значения переменной col
            {
                for (int i = matrix[0].Length; i < col; i++)
                    for (int j = 0; j < row; j++)
                        matrixNew[j][i] = rand.Next(10, 90); //то заполняем пустые столбцы нового массива рандомными значениями
            }

            matrix = matrixNew; //Переменной matrix присваивается ссылка на матрицу matrixNew
        }
    }


}
