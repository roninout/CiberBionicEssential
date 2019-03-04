using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L02_TaskAdd01
{
    class Program
    {
        static void Main(string[] args)
        {
            //User user = new User();
            User user = new User("login", "Alex", "Petrov", 23);
            Console.WriteLine(new String('*', 45));
            Console.WriteLine($"Информация о пользователе - {user.Login}");
            Console.WriteLine($"Имя пользователя: {user.Name} {user.Surname}");
            Console.WriteLine($"Возраст: {user.Age}");
            Console.WriteLine($"Дата заполнения анкеты: {user.dateTime}");
            Console.WriteLine(new String('*', 45));
            Console.ReadKey();
        }
    }
}
