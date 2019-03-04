using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace L09_Task03
{
    class Program
    {
        private const int size = 3; // размер массива

        // этот класс делегат отвечает за выполнения метода ввода с клавиатуры
        delegate int InputDelegate();
        // а этот реализует анонимный метод
        delegate double AverDelegate(InputDelegate[] inputDel);

        // метод считывания значений с консоли
        static int GetDataFromConsole()
        {
            return int.Parse(Console.ReadLine());
        }

        static void Main(string[] args)
        {
            Console.WriteLine($"Введите {size} случайных int-числа");
            InputDelegate[] arrayDel = new InputDelegate[size]; // массив делегатов

            // наполняем методами ввода с клавиатуры
            // если бы не условия задачи, можно было "натолкать" и через += (без массива)
            for (int i = 0; i < size; i++)
                arrayDel[i] = GetDataFromConsole;

            /* анонимный метод вычисления сренего значения */
            AverDelegate aver = delegate (InputDelegate[] del)
            {
                double result = 0;
                foreach (InputDelegate item in del)
                    result += item(); //  а вот в этом месте мы их (методы) запускаем на выполнение и суммируем значения 
                return (double)result/size; //  и вычисляем среднее арифметическое
            };

            Console.WriteLine($"Среднее арифметическое: {aver(arrayDel) :##.##}"); // вызов анонимного метода (так саказать - старт)
            // ждем
            Console.ReadKey();
        }
    }
}
