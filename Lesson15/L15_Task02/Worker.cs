using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L15_Task02
{
    struct Worker
    {
        int yearOfEmployment;

        public Worker(string surname, string post, int yearOfEmployment) : this()
        {
            Post = post;
            Surname = surname;
            YearOfEmployment = yearOfEmployment;
        }

        public string Post { get; }
        public string Surname { get; }

        public int YearOfEmployment
        {
            get => yearOfEmployment;
            set
            {
                // Проверка на корректность ввода. Если поступил не сейчас и не работает больше 100 лет - то гуд
                try
                {
                    if (value <= DateTime.Now.Year && DateTime.Now.Year - value <= 100)
                        yearOfEmployment = value;
                    else
                    {
                        yearOfEmployment = DateTime.Now.Year;
                        throw new Exception();
                    }
                }
                catch (Exception) when (value == 0)
                {
                    Console.WriteLine("Сотрудник только поступил на работу - стажа 0!!!");
                }
                catch (Exception) when (DateTime.Now.Year - value < 0)
                {
                    Console.WriteLine("Гости из будущего!!!");
                }
                catch (Exception) when (DateTime.Now.Year - value > 100)
                {
                    Console.WriteLine("Это не серьезно!!! В наших рядах горец!!!");
                }
            }
        }

        public int WorkExperience() {
            return DateTime.Now.Year - yearOfEmployment;
        }
    }
}
