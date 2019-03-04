using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L15_Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Worker> workers = new SortedDictionary<string, Worker>();
            string surname;
            string post;
            int yearOfEmployment = 0;
            int workExperience = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(new string('*', 50));
                Console.Write("Введите имя сотрудника: ");
                surname = Console.ReadLine();

                Console.Write("Его должность: ");
                post = Console.ReadLine();

                try
                {
                    Console.Write("И год поступления на работу: ");
                    yearOfEmployment = Int32.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Упс! С годом что-то не то!!!");
                    yearOfEmployment = DateTime.Now.Year; // выставляем текущий год и опыт будет = 0;
                }
                workers.Add(surname, new Worker(surname, post, yearOfEmployment));
            }

            try
            {
                Console.WriteLine(new string('*', 50));
                Console.Write("Введите необходимый для Вас стаж сотрудников: ");
                workExperience = Int32.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Да что ж с руками-то!!! Будет произведен вывод сотрудников со стажем больше одного года!!!");
                workExperience = 1;
            }

            Console.WriteLine(new string('*', 50));
            foreach (var worker in workers)
            {
                if (worker.Value.WorkExperience() > workExperience)
                    Console.WriteLine($"Имя: {worker.Value.Surname}, должность: {worker.Value.Post}, год поступления: {worker.Value.YearOfEmployment} г. cтаж: { worker.Value.WorkExperience()}");
            }

            Console.ReadKey();
        }
    }
}
