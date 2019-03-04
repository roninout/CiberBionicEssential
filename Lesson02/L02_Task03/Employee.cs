using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L02_Task03
{
    class Employee
    {
        readonly string name = "";
        readonly string surname = "";

        string post = "";
        int experience;
        readonly double tax = 0.1;

        public string Surname
        {
            get
            {
                return surname;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
        }

        public string Post
        {
            get
            {
                return post;
            }
            set
            {
                // проверка на ввод
                if (value != null)
                {
                    post = value;
                }
            }
        }

        public int Experience
        {
            get
            {
                return experience;
            }
            set
            {
                // проверка на положительный опыт
                if (value >= 0)
                {
                    experience = value;
                }
            }
        }

        public Employee(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }

        private double PostToMoney(string post)
        {
            switch (post.ToLower())
            {
                case "cleaner":
                    return 100.0;
                case "programmer":
                    return 200.0;
                case "director":
                    return 300.0;
                default:
                    return 10.0;
            }
        }

        private double ExpToKoef(int exp)
        {
            switch (exp)
            {
                case 0:
                    return 1.0;
                case 1:
                    return 2.3;
                case 2:
                    return 3.4;
                default:
                    return 4.0;
            }
        }

        public void Pay(string post, int experience)
        {
            double pay = PostToMoney(post) * ExpToKoef(experience);
            Console.WriteLine("Оклад сотрудника {0} {1} состовляет: {2}. Налоговый сбор: {3}", name, Surname, pay, pay * tax);
            Console.WriteLine();
        }
    }
}
