using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L02_Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee cleaner = new Employee("Даша", "Петрова");
            cleaner.Pay("cleaner", 6);

            Employee programmer = new Employee("Маша", "Васильевна");
            programmer.Pay("programmer", 2);

            Employee director = new Employee("Элла", "Борисовна");
            director.Pay("director", 3);

            Employee noName = new Employee("Петя", "Неизвестный");
            noName.Pay("noName", 1);

            Console.ReadKey();
        }
    }
}
